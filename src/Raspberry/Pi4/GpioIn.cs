using System;

namespace Raspberry.Pi4;

public class GpioIn { 
    private const uint FSEL_REGISTER_METHODE_INPUT = 0b000u; 
    private const uint FSEL_REGISTER_METHODE_MASK = 0b111u; 
    public const uint LEV_OFFSET = 13;

    private unsafe volatile uint* _gpioMap = null!;
    public readonly uint GPIO;
    private unsafe volatile uint* _levRegisterOffset;
    private uint _levValueMask;

    unsafe internal GpioIn(uint* gpioMap, uint gpio)
    {
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
        *(_gpioMap + offset) = (*(_gpioMap + offset) & ~(FSEL_REGISTER_METHODE_MASK << (int) shift)); 
        // Not needed because 0 << n := 0 -> a | 0 := a
        /*| (FSEL_REGISTER_METHODE_INPUT << (int) shift);*/

        uint registerIndex = (gpio >> 5);
        _levRegisterOffset = _gpioMap + LEV_OFFSET + registerIndex;
        _levValueMask = 1u << (int)(gpio & 0b11111u);
    }

    public unsafe uint GetValueUint(){ 
        return (*_levRegisterOffset & _levValueMask) >> (int)(GPIO & 0b11111u);
    }
    
    public unsafe bool GetValueBool(){ 
        return (*_levRegisterOffset & _levValueMask) == _levValueMask;
    }
}