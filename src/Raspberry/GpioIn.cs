using Raspberry.Native;
using System;

namespace Raspberry;

public class GpioIn { 
    public uint GPIO { get; init; }

    private unsafe volatile uint* _gpioMap = null!;
    private unsafe volatile uint* _levRegisterOffset;
    private uint _levValueMask;

    unsafe internal GpioIn(uint* gpioMap, uint gpio, EnvironmentBase environment)
    {
        if(gpioMap == null) { 
            throw new ArgumentNullException(nameof(gpioMap));
        }

        if(gpio > environment.MAX_GPIO_COUNT) { 
            throw new NotSupportedException("The are only 57 GPIO's supported, please try a value below or equals.");
        }

        _gpioMap = gpioMap;
        GPIO = gpio;
    
        uint offset = environment.CalcFSELRegisterOffset(gpio);
        uint shift  = environment.CalcFSELRegisterShift(gpio);
        *(_gpioMap + offset) = (*(_gpioMap + offset) & ~(environment.FSEL_REGISTER_METHODE_MASK << (int) shift)); 
        // Not needed because 0 << n := 0 -> a | 0 := a
        /*| (FSEL_REGISTER_METHODE_INPUT << (int) shift);*/

        uint registerIndex = environment.CalcLEVRegisterIndex(gpio);
        _levRegisterOffset = _gpioMap + environment.LEV_OFFSET + registerIndex;
        _levValueMask = environment.CalcLEVRegisterMask(gpio);
    }
    
    public unsafe bool GetValueBool(){ 
        return (*_levRegisterOffset & _levValueMask) == _levValueMask;
    }
}