namespace Raspberry.Pi4;
public static class Enviroment
{
    /// <summary>
    /// 0xFE000000
    /// </summary>
    public const uint BCM2708_PERI_BASE = 0xFE000000;
    
    public static class GPIO
    {
        /// <summary>
        /// /dev/gpiomem
        /// </summary>
        public const string GPIO_MEM = @"/dev/gpiomem";
        /// <summary>
        /// /sys/class/gpio
        /// </summary>
        public const string GPIO_FILE_PATH = @"/sys/class/gpio";
        /// <summary>
        /// /sys/class/gpio/export
        /// </summary>
        public const string GPIO_FILE_PATH_EXPORT = @$"{GPIO_FILE_PATH}/export";
        /// <summary>
        /// /sys/class/gpio/import
        /// </summary>
        public const string GPIO_FILE_PATH_UNEXPORT = @$"{GPIO_FILE_PATH}/unexport";
        /// <summary>
        /// 0xFE200000
        /// </summary>
        public const uint GPIO_BASE = BCM2708_PERI_BASE + 0x200000;
        /// <summary>
        /// Pin 3
        /// </summary>
        public const byte GPIO_02 = 2;
        /// <summary>
        /// Pin 5
        /// </summary>
        public const byte GPIO_03 = 3;
        /// <summary>
        /// Pin 7
        /// </summary>
        public const byte GPIO_04 = 4;
        /// <summary>
        /// Pin 11
        /// </summary>
        public const byte GPIO_17 = 17;
        /// <summary>
        /// Pin 13
        /// </summary>
        public const byte GPIO_27 = 27;
        /// <summary>
        /// Pin 15
        /// </summary>
        public const byte GPIO_22 = 22;
        /// <summary>
        /// Pin 19
        /// </summary>
        public const byte GPIO_10 = 10;
        /// <summary>
        /// Pin 21
        /// </summary>
        public const byte GPIO_09 = 9;
        /// <summary>
        /// Pin 23
        /// </summary>
        public const byte GPIO_11 = 11;
        /// <summary>
        /// Pin 29
        /// </summary>
        public const byte GPIO_05 = 5;
        /// <summary>
        /// Pin 31
        /// </summary>
        public const byte GPIO_06 = 6;
        /// <summary>
        /// Pin 33
        /// </summary>
        public const byte GPIO_13 = 13;
        /// <summary>
        /// Pin 35
        /// </summary>
        public const byte GPIO_19 = 19;
        /// <summary>
        /// Pin 37
        /// </summary>
        public const byte GPIO_26 = 26;
        /// <summary>
        /// Pin 8
        /// </summary>
        public const byte GPIO_14 = 14;
        /// <summary>
        /// Pin 10
        /// </summary>
        public const byte GPIO_15 = 15;
        /// <summary>
        /// Pin 12
        /// </summary>
        public const byte GPIO_18 = 18;
        /// <summary>
        /// Pin 16
        /// </summary>
        public const byte GPIO_23 = 23;
        /// <summary>
        /// Pin 18
        /// </summary>
        public const byte GPIO_24 = 24;
        /// <summary>
        /// Pin 22
        /// </summary>
        public const byte GPIO_25 = 25;
        /// <summary>
        /// Pin 24
        /// </summary>
        public const byte GPIO_08 = 8;
        /// <summary>
        /// Pin 26
        /// </summary>
        public const byte GPIO_07 = 7;
        /// <summary>
        /// Pin 32
        /// </summary>
        public const byte GPIO_12 = 12;
        /// <summary>
        /// Pin 36
        /// </summary>
        public const byte GPIO_16 = 16;
        /// <summary>
        /// Pin 38
        /// </summary>
        public const byte GPIO_20 = 20;
        /// <summary>
        /// Pin 40
        /// </summary>
        public const byte GPIO_21 = 21;
        /// <summary>
        /// GPIO Function Select 0
        /// </summary>
        public const uint GPFSEL0_REGISTER = 0x00;
        /// <summary>
        /// GPIO Function Select 1
        /// </summary>
        public const uint GPFSEL1_REGISTER = 0x04;
        /// <summary>
        /// GPIO Function Select 2
        /// </summary>
        public const uint GPFSEL2_REGISTER = 0x08;
        /// <summary>
        /// GPIO Function Select 3
        /// </summary>
        public const uint GPFSEL3_REGISTER = 0x0c;
        /// <summary>
        /// GPIO Function Select 4
        /// </summary>
        public const uint GPFSEL4_REGISTER = 0x10;
        /// <summary>
        /// GPIO Function Select 5
        /// </summary>
        public const uint GPFSEL5_REGISTER = 0x14;
        /// <summary>
        /// GPIO Pin Output Set 0
        /// </summary>
        public const uint GPSET0_REGISTER = 0x1c;
        /// <summary>
        /// GPIO Pin Output Set 1
        /// </summary>
        public const uint GPSET1_REGISTER = 0x20;
        /// <summary>
        /// GPIO Pin Output Clear 0
        /// </summary>
        public const uint GPCLR0_REGISTER = 0x28;
        /// <summary>
        /// GPIO Pin Output Clear 1
        /// </summary>
        public const uint GPCLR1_REGISTER = 0x2c;
        /// <summary>
        /// GPIO Pin Level 0
        /// </summary>
        public const uint GPLEV0_REGISTER = 0x34;
        /// <summary>
        /// GPIO Pin Level 1
        /// </summary>
        public const uint GPLEV1_REGISTER = 0x38;
        /// <summary>
        /// GPIO Pin Event Detect Status 0
        /// </summary>
        public const uint GPEDS0_REGISTER = 0x40;
        /// <summary>
        /// GPIO Pin Event Detect Status 1
        /// </summary>
        public const uint GPEDS1_REGISTER = 0x44;
        /// <summary>
        /// GPIO Pin Rising Edge Detect Enable 0
        /// </summary>
        public const uint GPREN0_REGISTER = 0x4c;
        /// <summary>
        /// GPIO Pin Rising Edge Detect Enable 1
        /// </summary>
        public const uint GPREN1_REGISTER = 0x50;
        /// <summary>
        /// GPIO Pin Falling Edge Detect Enable 0
        /// </summary>
        public const uint GPFEN0_REGISTER = 0x58;
        /// <summary>
        /// GPIO Pin Falling Edge Detect Enable 1
        /// </summary>
        public const uint GPFEN1_REGISTER = 0x5c;
        /// <summary>
        /// GPIO Pin High Detect Enable 0
        /// </summary>
        public const uint GPHEN0_REGISTER = 0x64;
        /// <summary>
        /// GPIO Pin High Detect Enable 1
        /// </summary>
        public const uint GPHEN1_REGISTER = 0x68;
        /// <summary>
        /// GPIO Pin Low Detect Enable 0
        /// </summary>
        public const uint GPLEN0_REGISTER = 0x70;
        /// <summary>
        /// GPIO Pin Low Detect Enable 1
        /// </summary>
        public const uint GPLEN1_REGISTER = 0x74;
        /// <summary>
        /// GPIO Pin Async.Rising Edge Detect 0
        /// </summary>
        public const uint GPAREN0_REGISTER = 0x7c;
        /// <summary>
        /// GPIO Pin Async. Rising Edge Detect 1
        /// </summary>
        public const uint GPAREN1_REGISTER = 0x80;
        /// <summary>
        /// GPIO Pin Async. Falling Edge Detect 0
        /// </summary>
        public const uint GPAFEN0_REGISTER = 0x88;
        /// <summary>
        /// GPIO Pin Async. Falling Edge Detect 1
        /// </summary>
        public const uint GPAFEN1_REGISTER = 0x8c;
        /// <summary>
        /// GPIO Pull-up / Pull-down Register 0
        /// </summary>
        public const uint GPIO_PUP_PDN_CNTRL_REG0_REGISTER = 0xe4;
        /// <summary>
        /// GPIO Pull-up / Pull-down Register 1
        /// </summary>
        public const uint GPIO_PUP_PDN_CNTRL_REG1_REGISTER = 0xe8;
        /// <summary>
        /// GPIO Pull-up / Pull-down Register 2
        /// </summary>
        public const uint GPIO_PUP_PDN_CNTRL_REG2_REGISTER = 0xec;
        /// <summary>
        /// GPIO Pull-up / Pull-down Register 3
        /// </summary>
        public const uint GPIO_PUP_PDN_CNTRL_REG3_REGISTER = 0xf0;
    }
}
