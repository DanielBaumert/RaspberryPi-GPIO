using Raspberry.Native;
using System;
using System.Diagnostics;
using System.Threading;

namespace Raspberry;

public class GpioOut
{
    public uint GPIO { get; init; }

    private unsafe volatile uint* _gpioMap = null!;

    private unsafe volatile uint* _setRegisterOffset;
    private uint _setValue;

    private unsafe volatile uint* _clrRegisterOffset;
    private uint _clrValue;

    private SpinLock _spinLockState = new SpinLock(Debugger.IsAttached);

    unsafe internal GpioOut(uint* gpioMap, uint gpio, EnvironmentBase environment)
    {
        if (gpioMap == null)
        {
            throw new ArgumentNullException(nameof(gpioMap));
        }

        if (gpio > environment.MAX_GPIO_COUNT)
        {
            throw new NotSupportedException("The are only 57 GPIO's supported, please try a value below or equals.");
        }

        _gpioMap = gpioMap;
        GPIO = gpio;

        uint offset = environment.CalcFSELRegisterOffset(gpio);
        uint shift = environment.CalcFSELRegisterShift(gpio);
        *(_gpioMap + offset) = (*(_gpioMap + offset) & ~(environment.FSEL_REGISTER_METHODE_MASK << (int)shift)) | (environment.FSEL_REGISTER_METHODE_OUTPUT << (int)shift);

        // set and clr can be the same

        uint setRegisterIndex = environment.CalcSetRegisterIndex(gpio);
        _setRegisterOffset = _gpioMap + environment.SET_OFFSET + setRegisterIndex;
        _setValue = environment.CalcSetRegisterValue(gpio);

        uint clrRegisterIndex = environment.CalcClrRegisterIndex(gpio);
        _clrRegisterOffset = _gpioMap + environment.CLR_OFFSET + clrRegisterIndex;
        _clrValue = environment.CalcClrRegisterValue(gpio);

        // set to low
        *_clrRegisterOffset = _clrValue;
    }

    public unsafe void Low()
    {
        bool lockTaken = false;
        try
        {
            _spinLockState.Enter(ref lockTaken);
            *_setRegisterOffset = _setValue;
        }
        finally
        {
            if (lockTaken)
            {
                _spinLockState.Exit(false);
            }
        }
    }

    public unsafe void High()
    {
        bool lockTaken = false;
        try
        {
            _spinLockState.Enter(ref lockTaken);
            *_clrRegisterOffset = _clrValue;
        }
        finally
        {
            if (lockTaken)
            {
                _spinLockState.Exit(false);
            }
        }
    }

    public PWMController GetPWM(float freq)
    {
        return new PWMController(this, freq);
    }
}
