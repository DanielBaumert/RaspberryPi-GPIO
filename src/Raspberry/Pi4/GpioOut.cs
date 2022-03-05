using System;
using System.Diagnostics;
using System.Threading;

namespace Raspberry.Pi4;

public class GpioOut { 
    private const uint FSEL_REGISTER_METHODE_OUTPUT = 0b001u; 
    private const uint FSEL_REGISTER_METHODE_MASK = 0b111u; 
    public const uint SET_OFFSET = 7;
    public const uint CLR_OFFSET = 10;

    private unsafe volatile uint* _gpioMap = null!;
    public readonly uint GPIO;
    private unsafe volatile uint* _setRegisterOffset;
    private unsafe volatile uint* _clrRegisterOffset;
    private uint _clrsetValue;

    private SpinLock _spinLockState = new SpinLock(Debugger.IsAttached);

    unsafe internal GpioOut(uint* gpioMap, uint gpio) { 

        if(gpioMap == null) { 
            throw new ArgumentNullException(nameof(gpioMap));
        }

        if(gpio > 57) { 
            throw new NotSupportedException("The are only 57 GPIO's supported, please try a value below or equals.");
        }

        _gpioMap = gpioMap;
        GPIO = gpio;

        uint offset = gpio / 10;
        uint shift = (gpio % 10) * 3;
        *(_gpioMap + offset) = (*(_gpioMap + offset) & ~(FSEL_REGISTER_METHODE_MASK << (int) shift)) | (FSEL_REGISTER_METHODE_OUTPUT << (int) shift);

        uint registerIndex = (gpio >> 5);
        _setRegisterOffset = _gpioMap + SET_OFFSET + registerIndex;
        _clrRegisterOffset = _gpioMap + CLR_OFFSET + registerIndex; 
        _clrsetValue = 1u << (int)(gpio & 0b11111u);

        // set to low
        *_clrRegisterOffset = _clrsetValue;
    }
    
    public unsafe void Low() { 
        bool lockTaken = false;
        try{ 
            _spinLockState.Enter(ref lockTaken);
            *_clrRegisterOffset = _clrsetValue;
        } 
        finally
        {
            if(lockTaken){ 
                _spinLockState.Exit(false);
            }
        }
    }

    public unsafe void High(){ 
        bool lockTaken = false;
        try{ 
            _spinLockState.Enter(ref lockTaken);
            *_setRegisterOffset = _clrsetValue;
        } 
        finally
        {
            if(lockTaken){ 
                _spinLockState.Exit(false);
            }
        }
    }

    public PWMController GetPWM(float freq){ 
        return new PWMController(this, freq);
    }
}
