namespace Raspberry.Native;

public abstract class EnvironmentBase
{
    /// <summary>
    /// e.g.: /dev/gpiomem
    /// </summary>
    public abstract string GPIO_MEM { get; }
    /// <summary>
    /// e.g.: /sys/class/gpio
    /// </summary>
    public abstract string GPIO_FILE_PATH { get; }
    /// <summary>
    /// e.g.: /sys/class/gpio/export
    /// </summary>
    public string GPIO_FILE_PATH_EXPORT => @$"{GPIO_FILE_PATH}/export";
    /// <summary>
    /// e.g.: /sys/class/gpio/import
    /// </summary>
    public string GPIO_FILE_PATH_UNEXPORT => @$"{GPIO_FILE_PATH}/unexport";

    /// <summary>
    /// e.g: Pi4 - 57
    /// </summary>
    public abstract uint MAX_GPIO_COUNT { get; }
    /// <summary>
    /// e.g: Pi4 - 0xFE000000
    /// </summary>
    public abstract uint BCM_PERI_BASE { get; }
    /// <summary>
    /// e.g: Pi4 - 0x00200000
    /// </summary>
    public abstract uint GPIO_OFFSET { get; }
    /// <summary>
    /// e.g: Pi4 - 0xFE200000
    /// </summary>
    public uint GPIO_BASE => BCM_PERI_BASE + GPIO_OFFSET;

    /// <summary>
    /// Offset of the GPIO set register <br/>
    /// e.g: Pi4 - 0x07
    /// </summary>
    public abstract uint SET_OFFSET { get; }
    /// <summary>
    /// Offset of the GPIO clear register<br/>
    /// e.g: Pi4 - 0x0A
    /// </summary>
    public abstract uint CLR_OFFSET { get; }
    /// <summary>
    /// Offset of the GPIO level register<br/>
    /// e.g: Pi4 - 0x0D
    /// </summary>
    public abstract uint LEV_OFFSET { get; }
    /// <summary>
    /// GPIO funtion methode input <br/>
    /// e.g: Pi4 - 0b000
    /// </summary>
    public abstract uint FSEL_REGISTER_METHODE_INPUT { get; }
    /// <summary>
    /// GPIO funtion methode input <br/>
    /// e.g: Pi4 - 0b001
    /// </summary>
    public abstract uint FSEL_REGISTER_METHODE_OUTPUT { get; }
    /// <summary>
    /// GPIO funtion methode mask <br/>
    /// e.g: Pi4 - 0b111
    /// </summary>
    public abstract uint FSEL_REGISTER_METHODE_MASK { get; }

    public abstract uint CalcFSELRegisterOffset(uint gpio);
    public abstract uint CalcFSELRegisterShift(uint gpio);
    public abstract uint CalcLEVRegisterIndex(uint gpio);
    public abstract uint CalcLEVRegisterMask(uint gpio);
    public abstract uint CalcClrRegisterIndex(uint gpio);
    public abstract uint CalcClrRegisterValue(uint gpio);
    public abstract uint CalcSetRegisterIndex(uint gpio);
    public abstract uint CalcSetRegisterValue(uint gpio);
}
