namespace Raspberry.Pi4.Native;

public struct GpioRegister
{
    public GPFSEL0 GPFSEL0;
    public GPFSEL1 GPFSEL1;
    public GPFSEL2 GPFSEL2;
    public GPFSEL3 GPFSEL3;
    public GPFSEL4 GPFSEL4;
    public GPFSEL5 GPFSEL5;

    public GPSET0 GPSET0;
    public GPSET1 GPSET1;

    public GPCLR0 GPCLR0;
    public GPCLR1 GPCLR1;

    public GPLEV0 GPLEV0;
    public GPLEV1 GPLEV1;

    public GPEDS0 GPEDS0;
    public GPEDS1 GPEDS1;

    public GPREN0 GPPREN0;
    public GPREN1 GPPREN1;

    public GPFEN0 GPFEN0;
    public GPFEN1 GPFEN1;

    public GPHEN0 GPHEN0;
    public GPHEN1 GPHEN1;

    public GPLEN0 GPLEN0;
    public GPLEN1 GPLEN1;

    public GPAREN0 GPAREN0;
    public GPAREN1 GPAREN1;

    public GPAFEN0 GPAFEN0; 
    public GPAFEN1 GPAFEN1;

    public GPIO_PUP_PDN_CNTRL_REG0 GPIO_PUP_PDN_CNTRL_REG0;
    public GPIO_PUP_PDN_CNTRL_REG1 GPIO_PUP_PDN_CNTRL_REG1;
    public GPIO_PUP_PDN_CNTRL_REG2 GPIO_PUP_PDN_CNTRL_REG2;
    public GPIO_PUP_PDN_CNTRL_REG3 GPIO_PUP_PDN_CNTRL_REG3;
}

public enum FSELStatus
{
    Input = 0b000,
    Output = 0b001,
    Alt0 = 0b100,
    Alt1 = 0b101,
    Alt2 = 0b110,
    Alt3 = 0b111,
    Alt4 = 0b011,
    Alt5 = 0b010
}

public struct GPFSEL0
{
    private uint _innerValue;
    public FSELStatus FSEL0 { get => (FSELStatus)(_innerValue & (0b111 <<  0)); set => _innerValue = _innerValue & ~(0b111u <<  0) | (((uint)value & 0b111) <<  0); }
    public FSELStatus FSEL1 { get => (FSELStatus)(_innerValue & (0b111 <<  3)); set => _innerValue = _innerValue & ~(0b111u <<  3) | (((uint)value & 0b111) <<  3); }
    public FSELStatus FSEL2 { get => (FSELStatus)(_innerValue & (0b111 <<  9)); set => _innerValue = _innerValue & ~(0b111u <<  9) | (((uint)value & 0b111) <<  9); }
    public FSELStatus FSEL3 { get => (FSELStatus)(_innerValue & (0b111 << 12)); set => _innerValue = _innerValue & ~(0b111u << 12) | (((uint)value & 0b111) << 12); }
    public FSELStatus FSEL4 { get => (FSELStatus)(_innerValue & (0b111 << 15)); set => _innerValue = _innerValue & ~(0b111u << 15) | (((uint)value & 0b111) << 15); }
    public FSELStatus FSEL5 { get => (FSELStatus)(_innerValue & (0b111 << 18)); set => _innerValue = _innerValue & ~(0b111u << 18) | (((uint)value & 0b111) << 18); }
    public FSELStatus FSEL6 { get => (FSELStatus)(_innerValue & (0b111 << 21)); set => _innerValue = _innerValue & ~(0b111u << 21) | (((uint)value & 0b111) << 21); }
    public FSELStatus FSEL7 { get => (FSELStatus)(_innerValue & (0b111 << 24)); set => _innerValue = _innerValue & ~(0b111u << 24) | (((uint)value & 0b111) << 24); }
    public FSELStatus FSEL8 { get => (FSELStatus)(_innerValue & (0b111 << 27)); set => _innerValue = _innerValue & ~(0b111u << 27) | (((uint)value & 0b111) << 27); }
    public FSELStatus FSEL9 { get => (FSELStatus)(_innerValue & (0b111 << 27)); set => _innerValue = _innerValue & ~(0b111u << 27) | (((uint)value & 0b111) << 27); }

    public void Reset()
    {
        _innerValue = 0;
    }
}
public struct GPFSEL1
{
    private uint _innerValue;
    public FSELStatus FSEL10 { get => (FSELStatus)(_innerValue & (0b111 << 0)); set => _innerValue = _innerValue & ~(0b111u << 0) | (((uint)value & 0b111) << 0); }
    public FSELStatus FSEL11 { get => (FSELStatus)(_innerValue & (0b111 << 3)); set => _innerValue = _innerValue & ~(0b111u << 3) | (((uint)value & 0b111) << 3); }
    public FSELStatus FSEL12 { get => (FSELStatus)(_innerValue & (0b111 << 9)); set => _innerValue = _innerValue & ~(0b111u << 9) | (((uint)value & 0b111) << 9); }
    public FSELStatus FSEL13 { get => (FSELStatus)(_innerValue & (0b111 << 12)); set => _innerValue = _innerValue & ~(0b111u << 12) | (((uint)value & 0b111) << 12); }
    public FSELStatus FSEL14 { get => (FSELStatus)(_innerValue & (0b111 << 15)); set => _innerValue = _innerValue & ~(0b111u << 15) | (((uint)value & 0b111) << 15); }
    public FSELStatus FSEL15 { get => (FSELStatus)(_innerValue & (0b111 << 18)); set => _innerValue = _innerValue & ~(0b111u << 18) | (((uint)value & 0b111) << 18); }
    public FSELStatus FSEL16 { get => (FSELStatus)(_innerValue & (0b111 << 21)); set => _innerValue = _innerValue & ~(0b111u << 21) | (((uint)value & 0b111) << 21); }
    public FSELStatus FSEL17 { get => (FSELStatus)(_innerValue & (0b111 << 24)); set => _innerValue = _innerValue & ~(0b111u << 24) | (((uint)value & 0b111) << 24); }
    public FSELStatus FSEL18 { get => (FSELStatus)(_innerValue & (0b111 << 27)); set => _innerValue = _innerValue & ~(0b111u << 27) | (((uint)value & 0b111) << 27); }
    public FSELStatus FSEL19 { get => (FSELStatus)(_innerValue & (0b111 << 27)); set => _innerValue = _innerValue & ~(0b111u << 27) | (((uint)value & 0b111) << 27); }
    
    public void Reset()
    {
        _innerValue = 0;
    }
}
public struct GPFSEL2
{
    private uint _innerValue;
    public FSELStatus FSEL20 { get => (FSELStatus)(_innerValue & (0b111 << 0)); set => _innerValue = _innerValue & ~(0b111u << 0) | (((uint)value & 0b111) << 0); }
    public FSELStatus FSEL21 { get => (FSELStatus)(_innerValue & (0b111 << 3)); set => _innerValue = _innerValue & ~(0b111u << 3) | (((uint)value & 0b111) << 3); }
    public FSELStatus FSEL22 { get => (FSELStatus)(_innerValue & (0b111 << 9)); set => _innerValue = _innerValue & ~(0b111u << 9) | (((uint)value & 0b111) << 9); }
    public FSELStatus FSEL23 { get => (FSELStatus)(_innerValue & (0b111 << 12)); set => _innerValue = _innerValue & ~(0b111u << 12) | (((uint)value & 0b111) << 12); }
    public FSELStatus FSEL24 { get => (FSELStatus)(_innerValue & (0b111 << 15)); set => _innerValue = _innerValue & ~(0b111u << 15) | (((uint)value & 0b111) << 15); }
    public FSELStatus FSEL25 { get => (FSELStatus)(_innerValue & (0b111 << 18)); set => _innerValue = _innerValue & ~(0b111u << 18) | (((uint)value & 0b111) << 18); }
    public FSELStatus FSEL26 { get => (FSELStatus)(_innerValue & (0b111 << 21)); set => _innerValue = _innerValue & ~(0b111u << 21) | (((uint)value & 0b111) << 21); }
    public FSELStatus FSEL27 { get => (FSELStatus)(_innerValue & (0b111 << 24)); set => _innerValue = _innerValue & ~(0b111u << 24) | (((uint)value & 0b111) << 24); }
    public FSELStatus FSEL28 { get => (FSELStatus)(_innerValue & (0b111 << 27)); set => _innerValue = _innerValue & ~(0b111u << 27) | (((uint)value & 0b111) << 27); }
    public FSELStatus FSEL29 { get => (FSELStatus)(_innerValue & (0b111 << 27)); set => _innerValue = _innerValue & ~(0b111u << 27) | (((uint)value & 0b111) << 27); }

    public void Reset()
    {
        _innerValue = 0;
    }
}
public struct GPFSEL3
{
    private uint _innerValue;
    public FSELStatus FSEL30 { get => (FSELStatus)(_innerValue & (0b111 << 0)); set => _innerValue = _innerValue & ~(0b111u << 0) | (((uint)value & 0b111) << 0); }
    public FSELStatus FSEL31 { get => (FSELStatus)(_innerValue & (0b111 << 3)); set => _innerValue = _innerValue & ~(0b111u << 3) | (((uint)value & 0b111) << 3); }
    public FSELStatus FSEL32 { get => (FSELStatus)(_innerValue & (0b111 << 9)); set => _innerValue = _innerValue & ~(0b111u << 9) | (((uint)value & 0b111) << 9); }
    public FSELStatus FSEL33 { get => (FSELStatus)(_innerValue & (0b111 << 12)); set => _innerValue = _innerValue & ~(0b111u << 12) | (((uint)value & 0b111) << 12); }
    public FSELStatus FSEL34 { get => (FSELStatus)(_innerValue & (0b111 << 15)); set => _innerValue = _innerValue & ~(0b111u << 15) | (((uint)value & 0b111) << 15); }
    public FSELStatus FSEL35 { get => (FSELStatus)(_innerValue & (0b111 << 18)); set => _innerValue = _innerValue & ~(0b111u << 18) | (((uint)value & 0b111) << 18); }
    public FSELStatus FSEL36 { get => (FSELStatus)(_innerValue & (0b111 << 21)); set => _innerValue = _innerValue & ~(0b111u << 21) | (((uint)value & 0b111) << 21); }
    public FSELStatus FSEL37 { get => (FSELStatus)(_innerValue & (0b111 << 24)); set => _innerValue = _innerValue & ~(0b111u << 24) | (((uint)value & 0b111) << 24); }
    public FSELStatus FSEL38 { get => (FSELStatus)(_innerValue & (0b111 << 27)); set => _innerValue = _innerValue & ~(0b111u << 27) | (((uint)value & 0b111) << 27); }
    public FSELStatus FSEL39 { get => (FSELStatus)(_innerValue & (0b111 << 27)); set => _innerValue = _innerValue & ~(0b111u << 27) | (((uint)value & 0b111) << 27); }

    public void Reset()
    {
        _innerValue = 0;
    }
}
public struct GPFSEL4
{
    private uint _innerValue;
    public FSELStatus FSEL40 { get => (FSELStatus)(_innerValue & (0b111 << 0)); set => _innerValue = _innerValue & ~(0b111u << 0) | (((uint)value & 0b111) << 0); }
    public FSELStatus FSEL41 { get => (FSELStatus)(_innerValue & (0b111 << 3)); set => _innerValue = _innerValue & ~(0b111u << 3) | (((uint)value & 0b111) << 3); }
    public FSELStatus FSEL42 { get => (FSELStatus)(_innerValue & (0b111 << 9)); set => _innerValue = _innerValue & ~(0b111u << 9) | (((uint)value & 0b111) << 9); }
    public FSELStatus FSEL43 { get => (FSELStatus)(_innerValue & (0b111 << 12)); set => _innerValue = _innerValue & ~(0b111u << 12) | (((uint)value & 0b111) << 12); }
    public FSELStatus FSEL44 { get => (FSELStatus)(_innerValue & (0b111 << 15)); set => _innerValue = _innerValue & ~(0b111u << 15) | (((uint)value & 0b111) << 15); }
    public FSELStatus FSEL45 { get => (FSELStatus)(_innerValue & (0b111 << 18)); set => _innerValue = _innerValue & ~(0b111u << 18) | (((uint)value & 0b111) << 18); }
    public FSELStatus FSEL46 { get => (FSELStatus)(_innerValue & (0b111 << 21)); set => _innerValue = _innerValue & ~(0b111u << 21) | (((uint)value & 0b111) << 21); }
    public FSELStatus FSEL47 { get => (FSELStatus)(_innerValue & (0b111 << 24)); set => _innerValue = _innerValue & ~(0b111u << 24) | (((uint)value & 0b111) << 24); }
    public FSELStatus FSEL48 { get => (FSELStatus)(_innerValue & (0b111 << 27)); set => _innerValue = _innerValue & ~(0b111u << 27) | (((uint)value & 0b111) << 27); }
    public FSELStatus FSEL49 { get => (FSELStatus)(_innerValue & (0b111 << 27)); set => _innerValue = _innerValue & ~(0b111u << 27) | (((uint)value & 0b111) << 27); }


    public void Reset()
    {
        _innerValue = 0;
    }
}
public struct GPFSEL5
{
    private uint _innerValue;
    public FSELStatus FSEL50 { get => (FSELStatus)(_innerValue & (0b111 << 0)); set => _innerValue = _innerValue & ~(0b111u << 0) | (((uint)value & 0b111) << 0); }
    public FSELStatus FSEL51 { get => (FSELStatus)(_innerValue & (0b111 << 3)); set => _innerValue = _innerValue & ~(0b111u << 3) | (((uint)value & 0b111) << 3); }
    public FSELStatus FSEL52 { get => (FSELStatus)(_innerValue & (0b111 << 9)); set => _innerValue = _innerValue & ~(0b111u << 9) | (((uint)value & 0b111) << 9); }
    public FSELStatus FSEL53 { get => (FSELStatus)(_innerValue & (0b111 << 12)); set => _innerValue = _innerValue & ~(0b111u << 12) | (((uint)value & 0b111) << 12); }
    public FSELStatus FSEL54 { get => (FSELStatus)(_innerValue & (0b111 << 15)); set => _innerValue = _innerValue & ~(0b111u << 15) | (((uint)value & 0b111) << 15); }
    public FSELStatus FSEL55 { get => (FSELStatus)(_innerValue & (0b111 << 18)); set => _innerValue = _innerValue & ~(0b111u << 18) | (((uint)value & 0b111) << 18); }
    public FSELStatus FSEL56 { get => (FSELStatus)(_innerValue & (0b111 << 21)); set => _innerValue = _innerValue & ~(0b111u << 21) | (((uint)value & 0b111) << 21); }
    public FSELStatus FSEL57 { get => (FSELStatus)(_innerValue & (0b111 << 24)); set => _innerValue = _innerValue & ~(0b111u << 24) | (((uint)value & 0b111) << 24); }


    public void Reset()
    {
        _innerValue = 0;
    }
}


public enum GPSETStatus : uint
{
    NoEffect = 0,
    AsGPIO = 1
}
public struct GPSET0
{
    private uint _innerValue;

    public GPSETStatus GPIO00 { set => _innerValue = _innerValue & ~(1u <<  0) | (((uint)value & 0b1) << 0); }
    public GPSETStatus GPIO01 { set => _innerValue = _innerValue & ~(1u <<  1) | (((uint)value & 0b1) << 1); }
    public GPSETStatus GPIO02 { set => _innerValue = _innerValue & ~(1u <<  2) | (((uint)value & 0b1) << 2); }
    public GPSETStatus GPIO03 { set => _innerValue = _innerValue & ~(1u <<  3) | (((uint)value & 0b1) << 3); }
    public GPSETStatus GPIO04 { set => _innerValue = _innerValue & ~(1u <<  4) | (((uint)value & 0b1) << 4); }
    public GPSETStatus GPIO05 { set => _innerValue = _innerValue & ~(1u <<  5) | (((uint)value & 0b1) << 5); }
    public GPSETStatus GPIO06 { set => _innerValue = _innerValue & ~(1u <<  6) | (((uint)value & 0b1) << 6); }
    public GPSETStatus GPIO07 { set => _innerValue = _innerValue & ~(1u <<  7) | (((uint)value & 0b1) << 7); }
    public GPSETStatus GPIO08 { set => _innerValue = _innerValue & ~(1u <<  8) | (((uint)value & 0b1) << 8); }
    public GPSETStatus GPIO09 { set => _innerValue = _innerValue & ~(1u <<  9) | (((uint)value & 0b1) << 9); }
    public GPSETStatus GPIO10 { set => _innerValue = _innerValue & ~(1u << 10) | (((uint)value & 0b1) << 10); }
    public GPSETStatus GPIO11 { set => _innerValue = _innerValue & ~(1u << 11) | (((uint)value & 0b1) << 11); }
    public GPSETStatus GPIO12 { set => _innerValue = _innerValue & ~(1u << 12) | (((uint)value & 0b1) << 12); }
    public GPSETStatus GPIO13 { set => _innerValue = _innerValue & ~(1u << 13) | (((uint)value & 0b1) << 13); }
    public GPSETStatus GPIO14 { set => _innerValue = _innerValue & ~(1u << 14) | (((uint)value & 0b1) << 14); }
    public GPSETStatus GPIO15 { set => _innerValue = _innerValue & ~(1u << 15) | (((uint)value & 0b1) << 15); }
    public GPSETStatus GPIO16 { set => _innerValue = _innerValue & ~(1u << 16) | (((uint)value & 0b1) << 16); }
    public GPSETStatus GPIO17 { set => _innerValue = _innerValue & ~(1u << 17) | (((uint)value & 0b1) << 17); }
    public GPSETStatus GPIO18 { set => _innerValue = _innerValue & ~(1u << 18) | (((uint)value & 0b1) << 18); }
    public GPSETStatus GPIO19 { set => _innerValue = _innerValue & ~(1u << 19) | (((uint)value & 0b1) << 19); }
    public GPSETStatus GPIO20 { set => _innerValue = _innerValue & ~(1u << 20) | (((uint)value & 0b1) << 20); }
    public GPSETStatus GPIO21 { set => _innerValue = _innerValue & ~(1u << 21) | (((uint)value & 0b1) << 21); }
    public GPSETStatus GPIO22 { set => _innerValue = _innerValue & ~(1u << 22) | (((uint)value & 0b1) << 22); }
    public GPSETStatus GPIO23 { set => _innerValue = _innerValue & ~(1u << 23) | (((uint)value & 0b1) << 23); }
    public GPSETStatus GPIO24 { set => _innerValue = _innerValue & ~(1u << 24) | (((uint)value & 0b1) << 24); }
    public GPSETStatus GPIO25 { set => _innerValue = _innerValue & ~(1u << 25) | (((uint)value & 0b1) << 25); }
    public GPSETStatus GPIO26 { set => _innerValue = _innerValue & ~(1u << 26) | (((uint)value & 0b1) << 26); }
    public GPSETStatus GPIO27 { set => _innerValue = _innerValue & ~(1u << 27) | (((uint)value & 0b1) << 27); }
    public GPSETStatus GPIO28 { set => _innerValue = _innerValue & ~(1u << 28) | (((uint)value & 0b1) << 28); }
    public GPSETStatus GPIO29 { set => _innerValue = _innerValue & ~(1u << 29) | (((uint)value & 0b1) << 29); }
    public GPSETStatus GPIO30 { set => _innerValue = _innerValue & ~(1u << 30) | (((uint)value & 0b1) << 30); }
    public GPSETStatus GPIO31 { set => _innerValue = _innerValue & ~(1u << 31) | (((uint)value & 0b1) << 31); }
}
public struct GPSET1
{
    private uint _innerValue;
    public GPSETStatus GPIO32 { set => _innerValue = _innerValue & ~(1u <<  0) | (((uint)value & 0b1) << 0); }
    public GPSETStatus GPIO33 { set => _innerValue = _innerValue & ~(1u <<  1) | (((uint)value & 0b1) << 1); }
    public GPSETStatus GPIO34 { set => _innerValue = _innerValue & ~(1u <<  2) | (((uint)value & 0b1) << 2); }
    public GPSETStatus GPIO35 { set => _innerValue = _innerValue & ~(1u <<  3) | (((uint)value & 0b1) << 3); }
    public GPSETStatus GPIO36 { set => _innerValue = _innerValue & ~(1u <<  4) | (((uint)value & 0b1) << 4); }
    public GPSETStatus GPIO37 { set => _innerValue = _innerValue & ~(1u <<  5) | (((uint)value & 0b1) << 5); }
    public GPSETStatus GPIO38 { set => _innerValue = _innerValue & ~(1u <<  6) | (((uint)value & 0b1) << 6); }
    public GPSETStatus GPIO39 { set => _innerValue = _innerValue & ~(1u <<  7) | (((uint)value & 0b1) << 7); }
    public GPSETStatus GPIO40 { set => _innerValue = _innerValue & ~(1u <<  8) | (((uint)value & 0b1) << 8); }
    public GPSETStatus GPIO41 { set => _innerValue = _innerValue & ~(1u <<  9) | (((uint)value & 0b1) << 9); }
    public GPSETStatus GPIO42 { set => _innerValue = _innerValue & ~(1u << 10) | (((uint)value & 0b1) << 10); }
    public GPSETStatus GPIO43 { set => _innerValue = _innerValue & ~(1u << 11) | (((uint)value & 0b1) << 11); }
    public GPSETStatus GPIO44 { set => _innerValue = _innerValue & ~(1u << 12) | (((uint)value & 0b1) << 12); }
    public GPSETStatus GPIO45 { set => _innerValue = _innerValue & ~(1u << 13) | (((uint)value & 0b1) << 13); }
    public GPSETStatus GPIO46 { set => _innerValue = _innerValue & ~(1u << 14) | (((uint)value & 0b1) << 14); }
    public GPSETStatus GPIO47 { set => _innerValue = _innerValue & ~(1u << 15) | (((uint)value & 0b1) << 15); }
    public GPSETStatus GPIO48 { set => _innerValue = _innerValue & ~(1u << 16) | (((uint)value & 0b1) << 16); }
    public GPSETStatus GPIO49 { set => _innerValue = _innerValue & ~(1u << 17) | (((uint)value & 0b1) << 17); }
    public GPSETStatus GPIO50 { set => _innerValue = _innerValue & ~(1u << 18) | (((uint)value & 0b1) << 18); }
    public GPSETStatus GPIO51 { set => _innerValue = _innerValue & ~(1u << 19) | (((uint)value & 0b1) << 19); }
    public GPSETStatus GPIO52 { set => _innerValue = _innerValue & ~(1u << 20) | (((uint)value & 0b1) << 20); }
    public GPSETStatus GPIO53 { set => _innerValue = _innerValue & ~(1u << 21) | (((uint)value & 0b1) << 21); }
    public GPSETStatus GPIO54 { set => _innerValue = _innerValue & ~(1u << 22) | (((uint)value & 0b1) << 22); }
    public GPSETStatus GPIO55 { set => _innerValue = _innerValue & ~(1u << 23) | (((uint)value & 0b1) << 23); }
    public GPSETStatus GPIO56 { set => _innerValue = _innerValue & ~(1u << 24) | (((uint)value & 0b1) << 24); }
    public GPSETStatus GPIO57 { set => _innerValue = _innerValue & ~(1u << 25) | (((uint)value & 0b1) << 25); }
}


public enum GPCLRStatus : uint
{
    NoEffect = 0,
    ResetGPIO = 1
}
public struct GPCLR0
{
    private uint _innerValue;
    public GPCLRStatus GPIO00 { set => _innerValue = _innerValue & ~(1u << 0) | (((uint)value & 0b1) << 0); }
    public GPCLRStatus GPIO01 { set => _innerValue = _innerValue & ~(1u << 1) | (((uint)value & 0b1) << 1); }
    public GPCLRStatus GPIO02 { set => _innerValue = _innerValue & ~(1u << 2) | (((uint)value & 0b1) << 2); }
    public GPCLRStatus GPIO03 { set => _innerValue = _innerValue & ~(1u << 3) | (((uint)value & 0b1) << 3); }
    public GPCLRStatus GPIO04 { set => _innerValue = _innerValue & ~(1u << 4) | (((uint)value & 0b1) << 4); }
    public GPCLRStatus GPIO05 { set => _innerValue = _innerValue & ~(1u << 5) | (((uint)value & 0b1) << 5); }
    public GPCLRStatus GPIO06 { set => _innerValue = _innerValue & ~(1u << 6) | (((uint)value & 0b1) << 6); }
    public GPCLRStatus GPIO07 { set => _innerValue = _innerValue & ~(1u << 7) | (((uint)value & 0b1) << 7); }
    public GPCLRStatus GPIO08 { set => _innerValue = _innerValue & ~(1u << 8) | (((uint)value & 0b1) << 8); }
    public GPCLRStatus GPIO09 { set => _innerValue = _innerValue & ~(1u << 9) | (((uint)value & 0b1) << 9); }
    public GPCLRStatus GPIO10 { set => _innerValue = _innerValue & ~(1u << 10) | (((uint)value & 0b1) << 10); }
    public GPCLRStatus GPIO11 { set => _innerValue = _innerValue & ~(1u << 11) | (((uint)value & 0b1) << 11); }
    public GPCLRStatus GPIO12 { set => _innerValue = _innerValue & ~(1u << 12) | (((uint)value & 0b1) << 12); }
    public GPCLRStatus GPIO13 { set => _innerValue = _innerValue & ~(1u << 13) | (((uint)value & 0b1) << 13); }
    public GPCLRStatus GPIO14 { set => _innerValue = _innerValue & ~(1u << 14) | (((uint)value & 0b1) << 14); }
    public GPCLRStatus GPIO15 { set => _innerValue = _innerValue & ~(1u << 15) | (((uint)value & 0b1) << 15); }
    public GPCLRStatus GPIO16 { set => _innerValue = _innerValue & ~(1u << 16) | (((uint)value & 0b1) << 16); }
    public GPCLRStatus GPIO17 { set => _innerValue = _innerValue & ~(1u << 17) | (((uint)value & 0b1) << 17); }
    public GPCLRStatus GPIO18 { set => _innerValue = _innerValue & ~(1u << 18) | (((uint)value & 0b1) << 18); }
    public GPCLRStatus GPIO19 { set => _innerValue = _innerValue & ~(1u << 19) | (((uint)value & 0b1) << 19); }
    public GPCLRStatus GPIO20 { set => _innerValue = _innerValue & ~(1u << 20) | (((uint)value & 0b1) << 20); }
    public GPCLRStatus GPIO21 { set => _innerValue = _innerValue & ~(1u << 21) | (((uint)value & 0b1) << 21); }
    public GPCLRStatus GPIO22 { set => _innerValue = _innerValue & ~(1u << 22) | (((uint)value & 0b1) << 22); }
    public GPCLRStatus GPIO23 { set => _innerValue = _innerValue & ~(1u << 23) | (((uint)value & 0b1) << 23); }
    public GPCLRStatus GPIO24 { set => _innerValue = _innerValue & ~(1u << 24) | (((uint)value & 0b1) << 24); }
    public GPCLRStatus GPIO25 { set => _innerValue = _innerValue & ~(1u << 25) | (((uint)value & 0b1) << 25); }
    public GPCLRStatus GPIO26 { set => _innerValue = _innerValue & ~(1u << 26) | (((uint)value & 0b1) << 26); }
    public GPCLRStatus GPIO27 { set => _innerValue = _innerValue & ~(1u << 27) | (((uint)value & 0b1) << 27); }
    public GPCLRStatus GPIO28 { set => _innerValue = _innerValue & ~(1u << 28) | (((uint)value & 0b1) << 28); }
    public GPCLRStatus GPIO29 { set => _innerValue = _innerValue & ~(1u << 29) | (((uint)value & 0b1) << 29); }
    public GPCLRStatus GPIO30 { set => _innerValue = _innerValue & ~(1u << 30) | (((uint)value & 0b1) << 30); }
    public GPCLRStatus GPIO31 { set => _innerValue = _innerValue & ~(1u << 31) | (((uint)value & 0b1) << 31); }
}
public struct GPCLR1
{
    private uint _innerValue;
    public GPCLRStatus GPIO32 { set => _innerValue = _innerValue & ~(1u << 0) | (((uint)value & 0b1) << 0); }
    public GPCLRStatus GPIO33 { set => _innerValue = _innerValue & ~(1u << 1) | (((uint)value & 0b1) << 1); }
    public GPCLRStatus GPIO34 { set => _innerValue = _innerValue & ~(1u << 2) | (((uint)value & 0b1) << 2); }
    public GPCLRStatus GPIO35 { set => _innerValue = _innerValue & ~(1u << 3) | (((uint)value & 0b1) << 3); }
    public GPCLRStatus GPIO36 { set => _innerValue = _innerValue & ~(1u << 4) | (((uint)value & 0b1) << 4); }
    public GPCLRStatus GPIO37 { set => _innerValue = _innerValue & ~(1u << 5) | (((uint)value & 0b1) << 5); }
    public GPCLRStatus GPIO38 { set => _innerValue = _innerValue & ~(1u << 6) | (((uint)value & 0b1) << 6); }
    public GPCLRStatus GPIO39 { set => _innerValue = _innerValue & ~(1u << 7) | (((uint)value & 0b1) << 7); }
    public GPCLRStatus GPIO40 { set => _innerValue = _innerValue & ~(1u << 8) | (((uint)value & 0b1) << 8); }
    public GPCLRStatus GPIO41 { set => _innerValue = _innerValue & ~(1u << 9) | (((uint)value & 0b1) << 9); }
    public GPCLRStatus GPIO42 { set => _innerValue = _innerValue & ~(1u << 10) | (((uint)value & 0b1) << 10); }
    public GPCLRStatus GPIO43 { set => _innerValue = _innerValue & ~(1u << 11) | (((uint)value & 0b1) << 11); }
    public GPCLRStatus GPIO44 { set => _innerValue = _innerValue & ~(1u << 12) | (((uint)value & 0b1) << 12); }
    public GPCLRStatus GPIO45 { set => _innerValue = _innerValue & ~(1u << 13) | (((uint)value & 0b1) << 13); }
    public GPCLRStatus GPIO46 { set => _innerValue = _innerValue & ~(1u << 14) | (((uint)value & 0b1) << 14); }
    public GPCLRStatus GPIO47 { set => _innerValue = _innerValue & ~(1u << 15) | (((uint)value & 0b1) << 15); }
    public GPCLRStatus GPIO48 { set => _innerValue = _innerValue & ~(1u << 16) | (((uint)value & 0b1) << 16); }
    public GPCLRStatus GPIO49 { set => _innerValue = _innerValue & ~(1u << 17) | (((uint)value & 0b1) << 17); }
    public GPCLRStatus GPIO50 { set => _innerValue = _innerValue & ~(1u << 18) | (((uint)value & 0b1) << 18); }
    public GPCLRStatus GPIO51 { set => _innerValue = _innerValue & ~(1u << 19) | (((uint)value & 0b1) << 19); }
    public GPCLRStatus GPIO52 { set => _innerValue = _innerValue & ~(1u << 20) | (((uint)value & 0b1) << 20); }
    public GPCLRStatus GPIO53 { set => _innerValue = _innerValue & ~(1u << 21) | (((uint)value & 0b1) << 21); }
    public GPCLRStatus GPIO54 { set => _innerValue = _innerValue & ~(1u << 22) | (((uint)value & 0b1) << 22); }
    public GPCLRStatus GPIO55 { set => _innerValue = _innerValue & ~(1u << 23) | (((uint)value & 0b1) << 23); }
    public GPCLRStatus GPIO56 { set => _innerValue = _innerValue & ~(1u << 24) | (((uint)value & 0b1) << 24); }
    public GPCLRStatus GPIO57 { set => _innerValue = _innerValue & ~(1u << 25) | (((uint)value & 0b1) << 25); }
}


public enum GPLEVStatus
{
    Low = 0,
    High = 1
}
public readonly struct GPLEV0
{
    private readonly uint _innerValue;
    public GPLEVStatus GPIO00 => (GPLEVStatus)(_innerValue & (1u << 0));
    public GPLEVStatus GPIO01 => (GPLEVStatus)(_innerValue & (1u << 1));
    public GPLEVStatus GPIO02 => (GPLEVStatus)(_innerValue & (1u << 2));
    public GPLEVStatus GPIO03 => (GPLEVStatus)(_innerValue & (1u << 3));
    public GPLEVStatus GPIO04 => (GPLEVStatus)(_innerValue & (1u << 4));
    public GPLEVStatus GPIO05 => (GPLEVStatus)(_innerValue & (1u << 5));
    public GPLEVStatus GPIO06 => (GPLEVStatus)(_innerValue & (1u << 6));
    public GPLEVStatus GPIO07 => (GPLEVStatus)(_innerValue & (1u << 7));
    public GPLEVStatus GPIO08 => (GPLEVStatus)(_innerValue & (1u << 8));
    public GPLEVStatus GPIO09 => (GPLEVStatus)(_innerValue & (1u << 9));
    public GPLEVStatus GPIO10 => (GPLEVStatus)(_innerValue & (1u << 10));
    public GPLEVStatus GPIO11 => (GPLEVStatus)(_innerValue & (1u << 11));
    public GPLEVStatus GPIO12 => (GPLEVStatus)(_innerValue & (1u << 12));
    public GPLEVStatus GPIO13 => (GPLEVStatus)(_innerValue & (1u << 13));
    public GPLEVStatus GPIO14 => (GPLEVStatus)(_innerValue & (1u << 14));
    public GPLEVStatus GPIO15 => (GPLEVStatus)(_innerValue & (1u << 15));
    public GPLEVStatus GPIO16 => (GPLEVStatus)(_innerValue & (1u << 16));
    public GPLEVStatus GPIO17 => (GPLEVStatus)(_innerValue & (1u << 17));
    public GPLEVStatus GPIO18 => (GPLEVStatus)(_innerValue & (1u << 18));
    public GPLEVStatus GPIO19 => (GPLEVStatus)(_innerValue & (1u << 19));
    public GPLEVStatus GPIO20 => (GPLEVStatus)(_innerValue & (1u << 20));
    public GPLEVStatus GPIO21 => (GPLEVStatus)(_innerValue & (1u << 21));
    public GPLEVStatus GPIO22 => (GPLEVStatus)(_innerValue & (1u << 22));
    public GPLEVStatus GPIO23 => (GPLEVStatus)(_innerValue & (1u << 23));
    public GPLEVStatus GPIO24 => (GPLEVStatus)(_innerValue & (1u << 24));
    public GPLEVStatus GPIO25 => (GPLEVStatus)(_innerValue & (1u << 25));
    public GPLEVStatus GPIO26 => (GPLEVStatus)(_innerValue & (1u << 26));
    public GPLEVStatus GPIO27 => (GPLEVStatus)(_innerValue & (1u << 27));
    public GPLEVStatus GPIO28 => (GPLEVStatus)(_innerValue & (1u << 28));
    public GPLEVStatus GPIO29 => (GPLEVStatus)(_innerValue & (1u << 29));
    public GPLEVStatus GPIO30 => (GPLEVStatus)(_innerValue & (1u << 30));
    public GPLEVStatus GPIO31 => (GPLEVStatus)(_innerValue & (1u << 31));
}
public readonly struct GPLEV1
{
    private readonly uint _innerValue;
    public GPLEVStatus GPIO32 => (GPLEVStatus)(_innerValue & (1u << 0));
    public GPLEVStatus GPIO33 => (GPLEVStatus)(_innerValue & (1u << 1));
    public GPLEVStatus GPIO34 => (GPLEVStatus)(_innerValue & (1u << 2));
    public GPLEVStatus GPIO35 => (GPLEVStatus)(_innerValue & (1u << 3));
    public GPLEVStatus GPIO36 => (GPLEVStatus)(_innerValue & (1u << 4));
    public GPLEVStatus GPIO37 => (GPLEVStatus)(_innerValue & (1u << 5));
    public GPLEVStatus GPIO38 => (GPLEVStatus)(_innerValue & (1u << 6));
    public GPLEVStatus GPIO39 => (GPLEVStatus)(_innerValue & (1u << 7));
    public GPLEVStatus GPIO40 => (GPLEVStatus)(_innerValue & (1u << 8));
    public GPLEVStatus GPIO41 => (GPLEVStatus)(_innerValue & (1u << 9));
    public GPLEVStatus GPIO42 => (GPLEVStatus)(_innerValue & (1u << 10));
    public GPLEVStatus GPIO43 => (GPLEVStatus)(_innerValue & (1u << 11));
    public GPLEVStatus GPIO44 => (GPLEVStatus)(_innerValue & (1u << 12));
    public GPLEVStatus GPIO45 => (GPLEVStatus)(_innerValue & (1u << 13));
    public GPLEVStatus GPIO46 => (GPLEVStatus)(_innerValue & (1u << 14));
    public GPLEVStatus GPIO47 => (GPLEVStatus)(_innerValue & (1u << 15));
    public GPLEVStatus GPIO48 => (GPLEVStatus)(_innerValue & (1u << 16));
    public GPLEVStatus GPIO49 => (GPLEVStatus)(_innerValue & (1u << 17));
    public GPLEVStatus GPIO50 => (GPLEVStatus)(_innerValue & (1u << 18));
    public GPLEVStatus GPIO51 => (GPLEVStatus)(_innerValue & (1u << 19));
    public GPLEVStatus GPIO52 => (GPLEVStatus)(_innerValue & (1u << 20));
    public GPLEVStatus GPIO53 => (GPLEVStatus)(_innerValue & (1u << 21));
    public GPLEVStatus GPIO54 => (GPLEVStatus)(_innerValue & (1u << 22));
    public GPLEVStatus GPIO55 => (GPLEVStatus)(_innerValue & (1u << 23));
    public GPLEVStatus GPIO56 => (GPLEVStatus)(_innerValue & (1u << 24));
    public GPLEVStatus GPIO57 => (GPLEVStatus)(_innerValue & (1u << 25));
}


public enum GPEDSStatus
{
    EventNotDetected = 0,
    EventDetected = 1
}
public readonly struct GPEDS0
{
    private readonly uint _innerValue;
    public GPEDSStatus GPIO00 => (GPEDSStatus)(_innerValue & (1u << 0));
    public GPEDSStatus GPIO01 => (GPEDSStatus)(_innerValue & (1u << 1));
    public GPEDSStatus GPIO02 => (GPEDSStatus)(_innerValue & (1u << 2));
    public GPEDSStatus GPIO03 => (GPEDSStatus)(_innerValue & (1u << 3));
    public GPEDSStatus GPIO04 => (GPEDSStatus)(_innerValue & (1u << 4));
    public GPEDSStatus GPIO05 => (GPEDSStatus)(_innerValue & (1u << 5));
    public GPEDSStatus GPIO06 => (GPEDSStatus)(_innerValue & (1u << 6));
    public GPEDSStatus GPIO07 => (GPEDSStatus)(_innerValue & (1u << 7));
    public GPEDSStatus GPIO08 => (GPEDSStatus)(_innerValue & (1u << 8));
    public GPEDSStatus GPIO09 => (GPEDSStatus)(_innerValue & (1u << 9));
    public GPEDSStatus GPIO10 => (GPEDSStatus)(_innerValue & (1u << 10));
    public GPEDSStatus GPIO11 => (GPEDSStatus)(_innerValue & (1u << 11));
    public GPEDSStatus GPIO12 => (GPEDSStatus)(_innerValue & (1u << 12));
    public GPEDSStatus GPIO13 => (GPEDSStatus)(_innerValue & (1u << 13));
    public GPEDSStatus GPIO14 => (GPEDSStatus)(_innerValue & (1u << 14));
    public GPEDSStatus GPIO15 => (GPEDSStatus)(_innerValue & (1u << 15));
    public GPEDSStatus GPIO16 => (GPEDSStatus)(_innerValue & (1u << 16));
    public GPEDSStatus GPIO17 => (GPEDSStatus)(_innerValue & (1u << 17));
    public GPEDSStatus GPIO18 => (GPEDSStatus)(_innerValue & (1u << 18));
    public GPEDSStatus GPIO19 => (GPEDSStatus)(_innerValue & (1u << 19));
    public GPEDSStatus GPIO20 => (GPEDSStatus)(_innerValue & (1u << 20));
    public GPEDSStatus GPIO21 => (GPEDSStatus)(_innerValue & (1u << 21));
    public GPEDSStatus GPIO22 => (GPEDSStatus)(_innerValue & (1u << 22));
    public GPEDSStatus GPIO23 => (GPEDSStatus)(_innerValue & (1u << 23));
    public GPEDSStatus GPIO24 => (GPEDSStatus)(_innerValue & (1u << 24));
    public GPEDSStatus GPIO25 => (GPEDSStatus)(_innerValue & (1u << 25));
    public GPEDSStatus GPIO26 => (GPEDSStatus)(_innerValue & (1u << 26));
    public GPEDSStatus GPIO27 => (GPEDSStatus)(_innerValue & (1u << 27));
    public GPEDSStatus GPIO28 => (GPEDSStatus)(_innerValue & (1u << 28));
    public GPEDSStatus GPIO29 => (GPEDSStatus)(_innerValue & (1u << 29));
    public GPEDSStatus GPIO30 => (GPEDSStatus)(_innerValue & (1u << 30));
    public GPEDSStatus GPIO31 => (GPEDSStatus)(_innerValue & (1u << 31));
}
public readonly struct GPEDS1
{
    private readonly uint _innerValue;
    public GPEDSStatus GPIO32 => (GPEDSStatus)(_innerValue & (1u << 0));
    public GPEDSStatus GPIO33 => (GPEDSStatus)(_innerValue & (1u << 1));
    public GPEDSStatus GPIO34 => (GPEDSStatus)(_innerValue & (1u << 2));
    public GPEDSStatus GPIO35 => (GPEDSStatus)(_innerValue & (1u << 3));
    public GPEDSStatus GPIO36 => (GPEDSStatus)(_innerValue & (1u << 4));
    public GPEDSStatus GPIO37 => (GPEDSStatus)(_innerValue & (1u << 5));
    public GPEDSStatus GPIO38 => (GPEDSStatus)(_innerValue & (1u << 6));
    public GPEDSStatus GPIO39 => (GPEDSStatus)(_innerValue & (1u << 7));
    public GPEDSStatus GPIO40 => (GPEDSStatus)(_innerValue & (1u << 8));
    public GPEDSStatus GPIO41 => (GPEDSStatus)(_innerValue & (1u << 9));
    public GPEDSStatus GPIO42 => (GPEDSStatus)(_innerValue & (1u << 10));
    public GPEDSStatus GPIO43 => (GPEDSStatus)(_innerValue & (1u << 11));
    public GPEDSStatus GPIO44 => (GPEDSStatus)(_innerValue & (1u << 12));
    public GPEDSStatus GPIO45 => (GPEDSStatus)(_innerValue & (1u << 13));
    public GPEDSStatus GPIO46 => (GPEDSStatus)(_innerValue & (1u << 14));
    public GPEDSStatus GPIO47 => (GPEDSStatus)(_innerValue & (1u << 15));
    public GPEDSStatus GPIO48 => (GPEDSStatus)(_innerValue & (1u << 16));
    public GPEDSStatus GPIO49 => (GPEDSStatus)(_innerValue & (1u << 17));
    public GPEDSStatus GPIO50 => (GPEDSStatus)(_innerValue & (1u << 18));
    public GPEDSStatus GPIO51 => (GPEDSStatus)(_innerValue & (1u << 19));
    public GPEDSStatus GPIO52 => (GPEDSStatus)(_innerValue & (1u << 20));
    public GPEDSStatus GPIO53 => (GPEDSStatus)(_innerValue & (1u << 21));
    public GPEDSStatus GPIO54 => (GPEDSStatus)(_innerValue & (1u << 22));
    public GPEDSStatus GPIO55 => (GPEDSStatus)(_innerValue & (1u << 23));
    public GPEDSStatus GPIO56 => (GPEDSStatus)(_innerValue & (1u << 24));
    public GPEDSStatus GPIO57 => (GPEDSStatus)(_innerValue & (1u << 25));
}


public enum GPRENStatus
{
    RisingEdgeDetectDisabled = 0,
    RisingEdgeOn = 1
}
public struct GPREN0
{
    private uint _innerValue;
    public GPRENStatus GPIO00 { get => (GPRENStatus)(_innerValue & (1u << 0)); set => _innerValue = _innerValue & ~(1u << 0) | (((uint)value & 0b1) << 0); }
    public GPRENStatus GPIO01 { get => (GPRENStatus)(_innerValue & (1u << 1)); set => _innerValue = _innerValue & ~(1u << 1) | (((uint)value & 0b1) << 1); }
    public GPRENStatus GPIO02 { get => (GPRENStatus)(_innerValue & (1u << 2)); set => _innerValue = _innerValue & ~(1u << 2) | (((uint)value & 0b1) << 2); }
    public GPRENStatus GPIO03 { get => (GPRENStatus)(_innerValue & (1u << 3)); set => _innerValue = _innerValue & ~(1u << 3) | (((uint)value & 0b1) << 3); }
    public GPRENStatus GPIO04 { get => (GPRENStatus)(_innerValue & (1u << 4)); set => _innerValue = _innerValue & ~(1u << 4) | (((uint)value & 0b1) << 4); }
    public GPRENStatus GPIO05 { get => (GPRENStatus)(_innerValue & (1u << 5)); set => _innerValue = _innerValue & ~(1u << 5) | (((uint)value & 0b1) << 5); }
    public GPRENStatus GPIO06 { get => (GPRENStatus)(_innerValue & (1u << 6)); set => _innerValue = _innerValue & ~(1u << 6) | (((uint)value & 0b1) << 6); }
    public GPRENStatus GPIO07 { get => (GPRENStatus)(_innerValue & (1u << 7)); set => _innerValue = _innerValue & ~(1u << 7) | (((uint)value & 0b1) << 7); }
    public GPRENStatus GPIO08 { get => (GPRENStatus)(_innerValue & (1u << 8)); set => _innerValue = _innerValue & ~(1u << 8) | (((uint)value & 0b1) << 8); }
    public GPRENStatus GPIO09 { get => (GPRENStatus)(_innerValue & (1u << 9)); set => _innerValue = _innerValue & ~(1u << 9) | (((uint)value & 0b1) << 9); }
    public GPRENStatus GPIO10 { get => (GPRENStatus)(_innerValue & (1u << 10)); set => _innerValue = _innerValue & ~(1u << 10) | (((uint)value & 0b1) << 10); }
    public GPRENStatus GPIO11 { get => (GPRENStatus)(_innerValue & (1u << 11)); set => _innerValue = _innerValue & ~(1u << 11) | (((uint)value & 0b1) << 11); }
    public GPRENStatus GPIO12 { get => (GPRENStatus)(_innerValue & (1u << 12)); set => _innerValue = _innerValue & ~(1u << 12) | (((uint)value & 0b1) << 12); }
    public GPRENStatus GPIO13 { get => (GPRENStatus)(_innerValue & (1u << 13)); set => _innerValue = _innerValue & ~(1u << 13) | (((uint)value & 0b1) << 13); }
    public GPRENStatus GPIO14 { get => (GPRENStatus)(_innerValue & (1u << 14)); set => _innerValue = _innerValue & ~(1u << 14) | (((uint)value & 0b1) << 14); }
    public GPRENStatus GPIO15 { get => (GPRENStatus)(_innerValue & (1u << 15)); set => _innerValue = _innerValue & ~(1u << 15) | (((uint)value & 0b1) << 15); }
    public GPRENStatus GPIO16 { get => (GPRENStatus)(_innerValue & (1u << 16)); set => _innerValue = _innerValue & ~(1u << 16) | (((uint)value & 0b1) << 16); }
    public GPRENStatus GPIO17 { get => (GPRENStatus)(_innerValue & (1u << 17)); set => _innerValue = _innerValue & ~(1u << 17) | (((uint)value & 0b1) << 17); }
    public GPRENStatus GPIO18 { get => (GPRENStatus)(_innerValue & (1u << 18)); set => _innerValue = _innerValue & ~(1u << 18) | (((uint)value & 0b1) << 18); }
    public GPRENStatus GPIO19 { get => (GPRENStatus)(_innerValue & (1u << 19)); set => _innerValue = _innerValue & ~(1u << 19) | (((uint)value & 0b1) << 19); }
    public GPRENStatus GPIO20 { get => (GPRENStatus)(_innerValue & (1u << 20)); set => _innerValue = _innerValue & ~(1u << 20) | (((uint)value & 0b1) << 20); }
    public GPRENStatus GPIO21 { get => (GPRENStatus)(_innerValue & (1u << 21)); set => _innerValue = _innerValue & ~(1u << 21) | (((uint)value & 0b1) << 21); }
    public GPRENStatus GPIO22 { get => (GPRENStatus)(_innerValue & (1u << 22)); set => _innerValue = _innerValue & ~(1u << 22) | (((uint)value & 0b1) << 22); }
    public GPRENStatus GPIO23 { get => (GPRENStatus)(_innerValue & (1u << 23)); set => _innerValue = _innerValue & ~(1u << 23) | (((uint)value & 0b1) << 23); }
    public GPRENStatus GPIO24 { get => (GPRENStatus)(_innerValue & (1u << 24)); set => _innerValue = _innerValue & ~(1u << 24) | (((uint)value & 0b1) << 24); }
    public GPRENStatus GPIO25 { get => (GPRENStatus)(_innerValue & (1u << 25)); set => _innerValue = _innerValue & ~(1u << 25) | (((uint)value & 0b1) << 25); }
    public GPRENStatus GPIO26 { get => (GPRENStatus)(_innerValue & (1u << 26)); set => _innerValue = _innerValue & ~(1u << 26) | (((uint)value & 0b1) << 26); }
    public GPRENStatus GPIO27 { get => (GPRENStatus)(_innerValue & (1u << 27)); set => _innerValue = _innerValue & ~(1u << 27) | (((uint)value & 0b1) << 27); }
    public GPRENStatus GPIO28 { get => (GPRENStatus)(_innerValue & (1u << 28)); set => _innerValue = _innerValue & ~(1u << 28) | (((uint)value & 0b1) << 28); }
    public GPRENStatus GPIO29 { get => (GPRENStatus)(_innerValue & (1u << 29)); set => _innerValue = _innerValue & ~(1u << 29) | (((uint)value & 0b1) << 29); }
    public GPRENStatus GPIO30 { get => (GPRENStatus)(_innerValue & (1u << 30)); set => _innerValue = _innerValue & ~(1u << 30) | (((uint)value & 0b1) << 30); }
    public GPRENStatus GPIO31 { get => (GPRENStatus)(_innerValue & (1u << 31)); set => _innerValue = _innerValue & ~(1u << 31) | (((uint)value & 0b1) << 31); }
}
public struct GPREN1
{
    private uint _innerValue;
    public GPRENStatus GPIO32 { get => (GPRENStatus)(_innerValue & (1u << 0)); set => _innerValue = _innerValue & ~(1u << 0) | (((uint) value & 0b1) << 0); }
    public GPRENStatus GPIO33 { get => (GPRENStatus)(_innerValue & (1u << 1)); set => _innerValue = _innerValue & ~(1u << 1) | (((uint) value & 0b1) << 1); }
    public GPRENStatus GPIO34 { get => (GPRENStatus)(_innerValue & (1u << 2)); set => _innerValue = _innerValue & ~(1u << 2) | (((uint)value & 0b1) << 2); }
    public GPRENStatus GPIO35 { get => (GPRENStatus)(_innerValue & (1u << 3)); set => _innerValue = _innerValue & ~(1u << 3) | (((uint)value & 0b1) << 3); }
    public GPRENStatus GPIO36 { get => (GPRENStatus)(_innerValue & (1u << 4)); set => _innerValue = _innerValue & ~(1u << 4) | (((uint)value & 0b1) << 4); }
    public GPRENStatus GPIO37 { get => (GPRENStatus)(_innerValue & (1u << 5)); set => _innerValue = _innerValue & ~(1u << 5) | (((uint)value & 0b1) << 5); }
    public GPRENStatus GPIO38 { get => (GPRENStatus)(_innerValue & (1u << 6)); set => _innerValue = _innerValue & ~(1u << 6) | (((uint)value & 0b1) << 6); }
    public GPRENStatus GPIO39 { get => (GPRENStatus)(_innerValue & (1u << 7)); set => _innerValue = _innerValue & ~(1u << 7) | (((uint)value & 0b1) << 7); }
    public GPRENStatus GPIO40 { get => (GPRENStatus)(_innerValue & (1u << 8)); set => _innerValue = _innerValue & ~(1u << 8) | (((uint)value & 0b1) << 8); }
    public GPRENStatus GPIO41 { get => (GPRENStatus)(_innerValue & (1u << 9)); set => _innerValue = _innerValue & ~(1u << 9) | (((uint)value & 0b1) << 9); }
    public GPRENStatus GPIO42 { get => (GPRENStatus)(_innerValue & (1u << 10)); set => _innerValue = _innerValue & ~(1u << 10) | (((uint)value & 0b1) << 10); }
    public GPRENStatus GPIO43 { get => (GPRENStatus)(_innerValue & (1u << 11)); set => _innerValue = _innerValue & ~(1u << 11) | (((uint)value & 0b1) << 11); }
    public GPRENStatus GPIO44 { get => (GPRENStatus)(_innerValue & (1u << 12)); set => _innerValue = _innerValue & ~(1u << 12) | (((uint)value & 0b1) << 12); }
    public GPRENStatus GPIO45 { get => (GPRENStatus)(_innerValue & (1u << 13)); set => _innerValue = _innerValue & ~(1u << 13) | (((uint)value & 0b1) << 13); }
    public GPRENStatus GPIO46 { get => (GPRENStatus)(_innerValue & (1u << 14)); set => _innerValue = _innerValue & ~(1u << 14) | (((uint)value & 0b1) << 14); }
    public GPRENStatus GPIO47 { get => (GPRENStatus)(_innerValue & (1u << 15)); set => _innerValue = _innerValue & ~(1u << 15) | (((uint)value & 0b1) << 15); }
    public GPRENStatus GPIO48 { get => (GPRENStatus)(_innerValue & (1u << 16)); set => _innerValue = _innerValue & ~(1u << 16) | (((uint)value & 0b1) << 16); }
    public GPRENStatus GPIO49 { get => (GPRENStatus)(_innerValue & (1u << 17)); set => _innerValue = _innerValue & ~(1u << 17) | (((uint)value & 0b1) << 17); }
    public GPRENStatus GPIO50 { get => (GPRENStatus)(_innerValue & (1u << 18)); set => _innerValue = _innerValue & ~(1u << 18) | (((uint)value & 0b1) << 18); }
    public GPRENStatus GPIO51 { get => (GPRENStatus)(_innerValue & (1u << 19)); set => _innerValue = _innerValue & ~(1u << 19) | (((uint)value & 0b1) << 19); }
    public GPRENStatus GPIO52 { get => (GPRENStatus)(_innerValue & (1u << 20)); set => _innerValue = _innerValue & ~(1u << 20) | (((uint)value & 0b1) << 20); }
    public GPRENStatus GPIO53 { get => (GPRENStatus)(_innerValue & (1u << 21)); set => _innerValue = _innerValue & ~(1u << 21) | (((uint)value & 0b1) << 21); }
    public GPRENStatus GPIO54 { get => (GPRENStatus)(_innerValue & (1u << 22)); set => _innerValue = _innerValue & ~(1u << 22) | (((uint)value & 0b1) << 22); }
    public GPRENStatus GPIO55 { get => (GPRENStatus)(_innerValue & (1u << 23)); set => _innerValue = _innerValue & ~(1u << 23) | (((uint)value & 0b1) << 23); }
    public GPRENStatus GPIO56 { get => (GPRENStatus)(_innerValue & (1u << 24)); set => _innerValue = _innerValue & ~(1u << 24) | (((uint)value & 0b1) << 24); }
    public GPRENStatus GPIO57 { get => (GPRENStatus)(_innerValue & (1u << 25)); set => _innerValue = _innerValue & ~(1u << 25) | (((uint)value & 0b1) << 25); }
}


public enum GPFENStatus
{
    FallingEdgeDetectDisabled = 0,
    FallingEdgeOn = 1
}
public struct GPFEN0
{
    private uint _innerValue;
    public GPFENStatus GPIO00 { get => (GPFENStatus)(_innerValue & (1u << 0)); set => _innerValue = _innerValue & ~(1u << 0) | (((uint)value & 0b1) << 0); }
    public GPFENStatus GPIO01 { get => (GPFENStatus)(_innerValue & (1u << 1)); set => _innerValue = _innerValue & ~(1u << 1) | (((uint)value & 0b1) << 1); }
    public GPFENStatus GPIO02 { get => (GPFENStatus)(_innerValue & (1u << 2)); set => _innerValue = _innerValue & ~(1u << 2) | (((uint)value & 0b1) << 2); }
    public GPFENStatus GPIO03 { get => (GPFENStatus)(_innerValue & (1u << 3)); set => _innerValue = _innerValue & ~(1u << 3) | (((uint)value & 0b1) << 3); }
    public GPFENStatus GPIO04 { get => (GPFENStatus)(_innerValue & (1u << 4)); set => _innerValue = _innerValue & ~(1u << 4) | (((uint)value & 0b1) << 4); }
    public GPFENStatus GPIO05 { get => (GPFENStatus)(_innerValue & (1u << 5)); set => _innerValue = _innerValue & ~(1u << 5) | (((uint)value & 0b1) << 5); }
    public GPFENStatus GPIO06 { get => (GPFENStatus)(_innerValue & (1u << 6)); set => _innerValue = _innerValue & ~(1u << 6) | (((uint)value & 0b1) << 6); }
    public GPFENStatus GPIO07 { get => (GPFENStatus)(_innerValue & (1u << 7)); set => _innerValue = _innerValue & ~(1u << 7) | (((uint)value & 0b1) << 7); }
    public GPFENStatus GPIO08 { get => (GPFENStatus)(_innerValue & (1u << 8)); set => _innerValue = _innerValue & ~(1u << 8) | (((uint)value & 0b1) << 8); }
    public GPFENStatus GPIO09 { get => (GPFENStatus)(_innerValue & (1u << 9)); set => _innerValue = _innerValue & ~(1u << 9) | (((uint)value & 0b1) << 9); }
    public GPFENStatus GPIO10 { get => (GPFENStatus)(_innerValue & (1u << 10)); set => _innerValue = _innerValue & ~(1u << 10) | (((uint)value & 0b1) << 10); }
    public GPFENStatus GPIO11 { get => (GPFENStatus)(_innerValue & (1u << 11)); set => _innerValue = _innerValue & ~(1u << 11) | (((uint)value & 0b1) << 11); }
    public GPFENStatus GPIO12 { get => (GPFENStatus)(_innerValue & (1u << 12)); set => _innerValue = _innerValue & ~(1u << 12) | (((uint)value & 0b1) << 12); }
    public GPFENStatus GPIO13 { get => (GPFENStatus)(_innerValue & (1u << 13)); set => _innerValue = _innerValue & ~(1u << 13) | (((uint)value & 0b1) << 13); }
    public GPFENStatus GPIO14 { get => (GPFENStatus)(_innerValue & (1u << 14)); set => _innerValue = _innerValue & ~(1u << 14) | (((uint)value & 0b1) << 14); }
    public GPFENStatus GPIO15 { get => (GPFENStatus)(_innerValue & (1u << 15)); set => _innerValue = _innerValue & ~(1u << 15) | (((uint)value & 0b1) << 15); }
    public GPFENStatus GPIO16 { get => (GPFENStatus)(_innerValue & (1u << 16)); set => _innerValue = _innerValue & ~(1u << 16) | (((uint)value & 0b1) << 16); }
    public GPFENStatus GPIO17 { get => (GPFENStatus)(_innerValue & (1u << 17)); set => _innerValue = _innerValue & ~(1u << 17) | (((uint)value & 0b1) << 17); }
    public GPFENStatus GPIO18 { get => (GPFENStatus)(_innerValue & (1u << 18)); set => _innerValue = _innerValue & ~(1u << 18) | (((uint)value & 0b1) << 18); }
    public GPFENStatus GPIO19 { get => (GPFENStatus)(_innerValue & (1u << 19)); set => _innerValue = _innerValue & ~(1u << 19) | (((uint)value & 0b1) << 19); }
    public GPFENStatus GPIO20 { get => (GPFENStatus)(_innerValue & (1u << 20)); set => _innerValue = _innerValue & ~(1u << 20) | (((uint)value & 0b1) << 20); }
    public GPFENStatus GPIO21 { get => (GPFENStatus)(_innerValue & (1u << 21)); set => _innerValue = _innerValue & ~(1u << 21) | (((uint)value & 0b1) << 21); }
    public GPFENStatus GPIO22 { get => (GPFENStatus)(_innerValue & (1u << 22)); set => _innerValue = _innerValue & ~(1u << 22) | (((uint)value & 0b1) << 22); }
    public GPFENStatus GPIO23 { get => (GPFENStatus)(_innerValue & (1u << 23)); set => _innerValue = _innerValue & ~(1u << 23) | (((uint)value & 0b1) << 23); }
    public GPFENStatus GPIO24 { get => (GPFENStatus)(_innerValue & (1u << 24)); set => _innerValue = _innerValue & ~(1u << 24) | (((uint)value & 0b1) << 24); }
    public GPFENStatus GPIO25 { get => (GPFENStatus)(_innerValue & (1u << 25)); set => _innerValue = _innerValue & ~(1u << 25) | (((uint)value & 0b1) << 25); }
    public GPFENStatus GPIO26 { get => (GPFENStatus)(_innerValue & (1u << 26)); set => _innerValue = _innerValue & ~(1u << 26) | (((uint)value & 0b1) << 26); }
    public GPFENStatus GPIO27 { get => (GPFENStatus)(_innerValue & (1u << 27)); set => _innerValue = _innerValue & ~(1u << 27) | (((uint)value & 0b1) << 27); }
    public GPFENStatus GPIO28 { get => (GPFENStatus)(_innerValue & (1u << 28)); set => _innerValue = _innerValue & ~(1u << 28) | (((uint)value & 0b1) << 28); }
    public GPFENStatus GPIO29 { get => (GPFENStatus)(_innerValue & (1u << 29)); set => _innerValue = _innerValue & ~(1u << 29) | (((uint)value & 0b1) << 29); }
    public GPFENStatus GPIO30 { get => (GPFENStatus)(_innerValue & (1u << 30)); set => _innerValue = _innerValue & ~(1u << 30) | (((uint)value & 0b1) << 30); }
    public GPFENStatus GPIO31 { get => (GPFENStatus)(_innerValue & (1u << 31)); set => _innerValue = _innerValue & ~(1u << 31) | (((uint)value & 0b1) << 31); }
}
public struct GPFEN1
{
    private uint _innerValue;
    public GPFENStatus GPIO32 { get => (GPFENStatus)(_innerValue & (1u << 0)); set => _innerValue = _innerValue & ~(1u << 0) | (((uint)value & 0b1) << 0); }
    public GPFENStatus GPIO33 { get => (GPFENStatus)(_innerValue & (1u << 1)); set => _innerValue = _innerValue & ~(1u << 1) | (((uint)value & 0b1) << 1); }
    public GPFENStatus GPIO34 { get => (GPFENStatus)(_innerValue & (1u << 2)); set => _innerValue = _innerValue & ~(1u << 2) | (((uint)value & 0b1) << 2); }
    public GPFENStatus GPIO35 { get => (GPFENStatus)(_innerValue & (1u << 3)); set => _innerValue = _innerValue & ~(1u << 3) | (((uint)value & 0b1) << 3); }
    public GPFENStatus GPIO36 { get => (GPFENStatus)(_innerValue & (1u << 4)); set => _innerValue = _innerValue & ~(1u << 4) | (((uint)value & 0b1) << 4); }
    public GPFENStatus GPIO37 { get => (GPFENStatus)(_innerValue & (1u << 5)); set => _innerValue = _innerValue & ~(1u << 5) | (((uint)value & 0b1) << 5); }
    public GPFENStatus GPIO38 { get => (GPFENStatus)(_innerValue & (1u << 6)); set => _innerValue = _innerValue & ~(1u << 6) | (((uint)value & 0b1) << 6); }
    public GPFENStatus GPIO39 { get => (GPFENStatus)(_innerValue & (1u << 7)); set => _innerValue = _innerValue & ~(1u << 7) | (((uint)value & 0b1) << 7); }
    public GPFENStatus GPIO40 { get => (GPFENStatus)(_innerValue & (1u << 8)); set => _innerValue = _innerValue & ~(1u << 8) | (((uint)value & 0b1) << 8); }
    public GPFENStatus GPIO41 { get => (GPFENStatus)(_innerValue & (1u << 9)); set => _innerValue = _innerValue & ~(1u << 9) | (((uint)value & 0b1) << 9); }
    public GPFENStatus GPIO42 { get => (GPFENStatus)(_innerValue & (1u << 10)); set => _innerValue = _innerValue & ~(1u << 10) | (((uint)value & 0b1) << 10); }
    public GPFENStatus GPIO43 { get => (GPFENStatus)(_innerValue & (1u << 11)); set => _innerValue = _innerValue & ~(1u << 11) | (((uint)value & 0b1) << 11); }
    public GPFENStatus GPIO44 { get => (GPFENStatus)(_innerValue & (1u << 12)); set => _innerValue = _innerValue & ~(1u << 12) | (((uint)value & 0b1) << 12); }
    public GPFENStatus GPIO45 { get => (GPFENStatus)(_innerValue & (1u << 13)); set => _innerValue = _innerValue & ~(1u << 13) | (((uint)value & 0b1) << 13); }
    public GPFENStatus GPIO46 { get => (GPFENStatus)(_innerValue & (1u << 14)); set => _innerValue = _innerValue & ~(1u << 14) | (((uint)value & 0b1) << 14); }
    public GPFENStatus GPIO47 { get => (GPFENStatus)(_innerValue & (1u << 15)); set => _innerValue = _innerValue & ~(1u << 15) | (((uint)value & 0b1) << 15); }
    public GPFENStatus GPIO48 { get => (GPFENStatus)(_innerValue & (1u << 16)); set => _innerValue = _innerValue & ~(1u << 16) | (((uint)value & 0b1) << 16); }
    public GPFENStatus GPIO49 { get => (GPFENStatus)(_innerValue & (1u << 17)); set => _innerValue = _innerValue & ~(1u << 17) | (((uint)value & 0b1) << 17); }
    public GPFENStatus GPIO50 { get => (GPFENStatus)(_innerValue & (1u << 18)); set => _innerValue = _innerValue & ~(1u << 18) | (((uint)value & 0b1) << 18); }
    public GPFENStatus GPIO51 { get => (GPFENStatus)(_innerValue & (1u << 19)); set => _innerValue = _innerValue & ~(1u << 19) | (((uint)value & 0b1) << 19); }
    public GPFENStatus GPIO52 { get => (GPFENStatus)(_innerValue & (1u << 20)); set => _innerValue = _innerValue & ~(1u << 20) | (((uint)value & 0b1) << 20); }
    public GPFENStatus GPIO53 { get => (GPFENStatus)(_innerValue & (1u << 21)); set => _innerValue = _innerValue & ~(1u << 21) | (((uint)value & 0b1) << 21); }
    public GPFENStatus GPIO54 { get => (GPFENStatus)(_innerValue & (1u << 22)); set => _innerValue = _innerValue & ~(1u << 22) | (((uint)value & 0b1) << 22); }
    public GPFENStatus GPIO55 { get => (GPFENStatus)(_innerValue & (1u << 23)); set => _innerValue = _innerValue & ~(1u << 23) | (((uint)value & 0b1) << 23); }
    public GPFENStatus GPIO56 { get => (GPFENStatus)(_innerValue & (1u << 24)); set => _innerValue = _innerValue & ~(1u << 24) | (((uint)value & 0b1) << 24); }
    public GPFENStatus GPIO57 { get => (GPFENStatus)(_innerValue & (1u << 25)); set => _innerValue = _innerValue & ~(1u << 25) | (((uint)value & 0b1) << 25); }
}


public enum GPHENStatus
{
    /// <summary>
    /// High detect disabled on GPIO pin n
    /// </summary>
    HighDetectDisabled = 0,
    /// <summary>
    /// High on GPIO pin n sets corresponding bit in GPEDS0
    /// </summary>
    HighOn = 1
}
public struct GPHEN0
{
    private uint _innerValue;
    public GPHENStatus GPIO00 { get => (GPHENStatus)(_innerValue & (1u << 0)); set => _innerValue = _innerValue & ~(1u << 0) | (((uint)value & 0b1) << 0); }
    public GPHENStatus GPIO01 { get => (GPHENStatus)(_innerValue & (1u << 1)); set => _innerValue = _innerValue & ~(1u << 1) | (((uint)value & 0b1) << 1); }
    public GPHENStatus GPIO02 { get => (GPHENStatus)(_innerValue & (1u << 2)); set => _innerValue = _innerValue & ~(1u << 2) | (((uint)value & 0b1) << 2); }
    public GPHENStatus GPIO03 { get => (GPHENStatus)(_innerValue & (1u << 3)); set => _innerValue = _innerValue & ~(1u << 3) | (((uint)value & 0b1) << 3); }
    public GPHENStatus GPIO04 { get => (GPHENStatus)(_innerValue & (1u << 4)); set => _innerValue = _innerValue & ~(1u << 4) | (((uint)value & 0b1) << 4); }
    public GPHENStatus GPIO05 { get => (GPHENStatus)(_innerValue & (1u << 5)); set => _innerValue = _innerValue & ~(1u << 5) | (((uint)value & 0b1) << 5); }
    public GPHENStatus GPIO06 { get => (GPHENStatus)(_innerValue & (1u << 6)); set => _innerValue = _innerValue & ~(1u << 6) | (((uint)value & 0b1) << 6); }
    public GPHENStatus GPIO07 { get => (GPHENStatus)(_innerValue & (1u << 7)); set => _innerValue = _innerValue & ~(1u << 7) | (((uint)value & 0b1) << 7); }
    public GPHENStatus GPIO08 { get => (GPHENStatus)(_innerValue & (1u << 8)); set => _innerValue = _innerValue & ~(1u << 8) | (((uint)value & 0b1) << 8); }
    public GPHENStatus GPIO09 { get => (GPHENStatus)(_innerValue & (1u << 9)); set => _innerValue = _innerValue & ~(1u << 9) | (((uint)value & 0b1) << 9); }
    public GPHENStatus GPIO10 { get => (GPHENStatus)(_innerValue & (1u << 10)); set => _innerValue = _innerValue & ~(1u << 10) | (((uint)value & 0b1) << 10); }
    public GPHENStatus GPIO11 { get => (GPHENStatus)(_innerValue & (1u << 11)); set => _innerValue = _innerValue & ~(1u << 11) | (((uint)value & 0b1) << 11); }
    public GPHENStatus GPIO12 { get => (GPHENStatus)(_innerValue & (1u << 12)); set => _innerValue = _innerValue & ~(1u << 12) | (((uint)value & 0b1) << 12); }
    public GPHENStatus GPIO13 { get => (GPHENStatus)(_innerValue & (1u << 13)); set => _innerValue = _innerValue & ~(1u << 13) | (((uint)value & 0b1) << 13); }
    public GPHENStatus GPIO14 { get => (GPHENStatus)(_innerValue & (1u << 14)); set => _innerValue = _innerValue & ~(1u << 14) | (((uint)value & 0b1) << 14); }
    public GPHENStatus GPIO15 { get => (GPHENStatus)(_innerValue & (1u << 15)); set => _innerValue = _innerValue & ~(1u << 15) | (((uint)value & 0b1) << 15); }
    public GPHENStatus GPIO16 { get => (GPHENStatus)(_innerValue & (1u << 16)); set => _innerValue = _innerValue & ~(1u << 16) | (((uint)value & 0b1) << 16); }
    public GPHENStatus GPIO17 { get => (GPHENStatus)(_innerValue & (1u << 17)); set => _innerValue = _innerValue & ~(1u << 17) | (((uint)value & 0b1) << 17); }
    public GPHENStatus GPIO18 { get => (GPHENStatus)(_innerValue & (1u << 18)); set => _innerValue = _innerValue & ~(1u << 18) | (((uint)value & 0b1) << 18); }
    public GPHENStatus GPIO19 { get => (GPHENStatus)(_innerValue & (1u << 19)); set => _innerValue = _innerValue & ~(1u << 19) | (((uint)value & 0b1) << 19); }
    public GPHENStatus GPIO20 { get => (GPHENStatus)(_innerValue & (1u << 20)); set => _innerValue = _innerValue & ~(1u << 20) | (((uint)value & 0b1) << 20); }
    public GPHENStatus GPIO21 { get => (GPHENStatus)(_innerValue & (1u << 21)); set => _innerValue = _innerValue & ~(1u << 21) | (((uint)value & 0b1) << 21); }
    public GPHENStatus GPIO22 { get => (GPHENStatus)(_innerValue & (1u << 22)); set => _innerValue = _innerValue & ~(1u << 22) | (((uint)value & 0b1) << 22); }
    public GPHENStatus GPIO23 { get => (GPHENStatus)(_innerValue & (1u << 23)); set => _innerValue = _innerValue & ~(1u << 23) | (((uint)value & 0b1) << 23); }
    public GPHENStatus GPIO24 { get => (GPHENStatus)(_innerValue & (1u << 24)); set => _innerValue = _innerValue & ~(1u << 24) | (((uint)value & 0b1) << 24); }
    public GPHENStatus GPIO25 { get => (GPHENStatus)(_innerValue & (1u << 25)); set => _innerValue = _innerValue & ~(1u << 25) | (((uint)value & 0b1) << 25); }
    public GPHENStatus GPIO26 { get => (GPHENStatus)(_innerValue & (1u << 26)); set => _innerValue = _innerValue & ~(1u << 26) | (((uint)value & 0b1) << 26); }
    public GPHENStatus GPIO27 { get => (GPHENStatus)(_innerValue & (1u << 27)); set => _innerValue = _innerValue & ~(1u << 27) | (((uint)value & 0b1) << 27); }
    public GPHENStatus GPIO28 { get => (GPHENStatus)(_innerValue & (1u << 28)); set => _innerValue = _innerValue & ~(1u << 28) | (((uint)value & 0b1) << 28); }
    public GPHENStatus GPIO29 { get => (GPHENStatus)(_innerValue & (1u << 29)); set => _innerValue = _innerValue & ~(1u << 29) | (((uint)value & 0b1) << 29); }
    public GPHENStatus GPIO30 { get => (GPHENStatus)(_innerValue & (1u << 30)); set => _innerValue = _innerValue & ~(1u << 30) | (((uint)value & 0b1) << 30); }
    public GPHENStatus GPIO31 { get => (GPHENStatus)(_innerValue & (1u << 31)); set => _innerValue = _innerValue & ~(1u << 31) | (((uint)value & 0b1) << 31); }
}
public struct GPHEN1
{
    private uint _innerValue;
    public GPHENStatus GPIO32 { get => (GPHENStatus)(_innerValue & (1u << 0)); set => _innerValue = _innerValue & ~(1u << 0) | (((uint)value & 0b1) << 0); }
    public GPHENStatus GPIO33 { get => (GPHENStatus)(_innerValue & (1u << 1)); set => _innerValue = _innerValue & ~(1u << 1) | (((uint)value & 0b1) << 1); }
    public GPHENStatus GPIO34 { get => (GPHENStatus)(_innerValue & (1u << 2)); set => _innerValue = _innerValue & ~(1u << 2) | (((uint)value & 0b1) << 2); }
    public GPHENStatus GPIO35 { get => (GPHENStatus)(_innerValue & (1u << 3)); set => _innerValue = _innerValue & ~(1u << 3) | (((uint)value & 0b1) << 3); }
    public GPHENStatus GPIO36 { get => (GPHENStatus)(_innerValue & (1u << 4)); set => _innerValue = _innerValue & ~(1u << 4) | (((uint)value & 0b1) << 4); }
    public GPHENStatus GPIO37 { get => (GPHENStatus)(_innerValue & (1u << 5)); set => _innerValue = _innerValue & ~(1u << 5) | (((uint)value & 0b1) << 5); }
    public GPHENStatus GPIO38 { get => (GPHENStatus)(_innerValue & (1u << 6)); set => _innerValue = _innerValue & ~(1u << 6) | (((uint)value & 0b1) << 6); }
    public GPHENStatus GPIO39 { get => (GPHENStatus)(_innerValue & (1u << 7)); set => _innerValue = _innerValue & ~(1u << 7) | (((uint)value & 0b1) << 7); }
    public GPHENStatus GPIO40 { get => (GPHENStatus)(_innerValue & (1u << 8)); set => _innerValue = _innerValue & ~(1u << 8) | (((uint)value & 0b1) << 8); }
    public GPHENStatus GPIO41 { get => (GPHENStatus)(_innerValue & (1u << 9)); set => _innerValue = _innerValue & ~(1u << 9) | (((uint)value & 0b1) << 9); }
    public GPHENStatus GPIO42 { get => (GPHENStatus)(_innerValue & (1u << 10)); set => _innerValue = _innerValue & ~(1u << 10) | (((uint)value & 0b1) << 10); }
    public GPHENStatus GPIO43 { get => (GPHENStatus)(_innerValue & (1u << 11)); set => _innerValue = _innerValue & ~(1u << 11) | (((uint)value & 0b1) << 11); }
    public GPHENStatus GPIO44 { get => (GPHENStatus)(_innerValue & (1u << 12)); set => _innerValue = _innerValue & ~(1u << 12) | (((uint)value & 0b1) << 12); }
    public GPHENStatus GPIO45 { get => (GPHENStatus)(_innerValue & (1u << 13)); set => _innerValue = _innerValue & ~(1u << 13) | (((uint)value & 0b1) << 13); }
    public GPHENStatus GPIO46 { get => (GPHENStatus)(_innerValue & (1u << 14)); set => _innerValue = _innerValue & ~(1u << 14) | (((uint)value & 0b1) << 14); }
    public GPHENStatus GPIO47 { get => (GPHENStatus)(_innerValue & (1u << 15)); set => _innerValue = _innerValue & ~(1u << 15) | (((uint)value & 0b1) << 15); }
    public GPHENStatus GPIO48 { get => (GPHENStatus)(_innerValue & (1u << 16)); set => _innerValue = _innerValue & ~(1u << 16) | (((uint)value & 0b1) << 16); }
    public GPHENStatus GPIO49 { get => (GPHENStatus)(_innerValue & (1u << 17)); set => _innerValue = _innerValue & ~(1u << 17) | (((uint)value & 0b1) << 17); }
    public GPHENStatus GPIO50 { get => (GPHENStatus)(_innerValue & (1u << 18)); set => _innerValue = _innerValue & ~(1u << 18) | (((uint)value & 0b1) << 18); }
    public GPHENStatus GPIO51 { get => (GPHENStatus)(_innerValue & (1u << 19)); set => _innerValue = _innerValue & ~(1u << 19) | (((uint)value & 0b1) << 19); }
    public GPHENStatus GPIO52 { get => (GPHENStatus)(_innerValue & (1u << 20)); set => _innerValue = _innerValue & ~(1u << 20) | (((uint)value & 0b1) << 20); }
    public GPHENStatus GPIO53 { get => (GPHENStatus)(_innerValue & (1u << 21)); set => _innerValue = _innerValue & ~(1u << 21) | (((uint)value & 0b1) << 21); }
    public GPHENStatus GPIO54 { get => (GPHENStatus)(_innerValue & (1u << 22)); set => _innerValue = _innerValue & ~(1u << 22) | (((uint)value & 0b1) << 22); }
    public GPHENStatus GPIO55 { get => (GPHENStatus)(_innerValue & (1u << 23)); set => _innerValue = _innerValue & ~(1u << 23) | (((uint)value & 0b1) << 23); }
    public GPHENStatus GPIO56 { get => (GPHENStatus)(_innerValue & (1u << 24)); set => _innerValue = _innerValue & ~(1u << 24) | (((uint)value & 0b1) << 24); }
    public GPHENStatus GPIO57 { get => (GPHENStatus)(_innerValue & (1u << 25)); set => _innerValue = _innerValue & ~(1u << 25) | (((uint)value & 0b1) << 25); }
}


public enum GPLENStatus
{
    /// <summary>
    ///  Low detect disabled on GPIO pin n
    /// </summary>
    LowDetectDisabled = 0,
    /// <summary>
    /// Low on GPIO pin n sets corresponding bit in GPEDS0
    /// </summary>
    LowOn = 1
}
public struct GPLEN0
{
    private uint _innerValue;
    public GPLENStatus GPIO00 { get => (GPLENStatus)(_innerValue & (1u << 0)); set => _innerValue = _innerValue & ~(1u << 0) | (((uint)value & 0b1) << 0); }
    public GPLENStatus GPIO01 { get => (GPLENStatus)(_innerValue & (1u << 1)); set => _innerValue = _innerValue & ~(1u << 1) | (((uint)value & 0b1) << 1); }
    public GPLENStatus GPIO02 { get => (GPLENStatus)(_innerValue & (1u << 2)); set => _innerValue = _innerValue & ~(1u << 2) | (((uint)value & 0b1) << 2); }
    public GPLENStatus GPIO03 { get => (GPLENStatus)(_innerValue & (1u << 3)); set => _innerValue = _innerValue & ~(1u << 3) | (((uint)value & 0b1) << 3); }
    public GPLENStatus GPIO04 { get => (GPLENStatus)(_innerValue & (1u << 4)); set => _innerValue = _innerValue & ~(1u << 4) | (((uint)value & 0b1) << 4); }
    public GPLENStatus GPIO05 { get => (GPLENStatus)(_innerValue & (1u << 5)); set => _innerValue = _innerValue & ~(1u << 5) | (((uint)value & 0b1) << 5); }
    public GPLENStatus GPIO06 { get => (GPLENStatus)(_innerValue & (1u << 6)); set => _innerValue = _innerValue & ~(1u << 6) | (((uint)value & 0b1) << 6); }
    public GPLENStatus GPIO07 { get => (GPLENStatus)(_innerValue & (1u << 7)); set => _innerValue = _innerValue & ~(1u << 7) | (((uint)value & 0b1) << 7); }
    public GPLENStatus GPIO08 { get => (GPLENStatus)(_innerValue & (1u << 8)); set => _innerValue = _innerValue & ~(1u << 8) | (((uint)value & 0b1) << 8); }
    public GPLENStatus GPIO09 { get => (GPLENStatus)(_innerValue & (1u << 9)); set => _innerValue = _innerValue & ~(1u << 9) | (((uint)value & 0b1) << 9); }
    public GPLENStatus GPIO10 { get => (GPLENStatus)(_innerValue & (1u << 10)); set => _innerValue = _innerValue & ~(1u << 10) | (((uint)value & 0b1) << 10); }
    public GPLENStatus GPIO11 { get => (GPLENStatus)(_innerValue & (1u << 11)); set => _innerValue = _innerValue & ~(1u << 11) | (((uint)value & 0b1) << 11); }
    public GPLENStatus GPIO12 { get => (GPLENStatus)(_innerValue & (1u << 12)); set => _innerValue = _innerValue & ~(1u << 12) | (((uint)value & 0b1) << 12); }
    public GPLENStatus GPIO13 { get => (GPLENStatus)(_innerValue & (1u << 13)); set => _innerValue = _innerValue & ~(1u << 13) | (((uint)value & 0b1) << 13); }
    public GPLENStatus GPIO14 { get => (GPLENStatus)(_innerValue & (1u << 14)); set => _innerValue = _innerValue & ~(1u << 14) | (((uint)value & 0b1) << 14); }
    public GPLENStatus GPIO15 { get => (GPLENStatus)(_innerValue & (1u << 15)); set => _innerValue = _innerValue & ~(1u << 15) | (((uint)value & 0b1) << 15); }
    public GPLENStatus GPIO16 { get => (GPLENStatus)(_innerValue & (1u << 16)); set => _innerValue = _innerValue & ~(1u << 16) | (((uint)value & 0b1) << 16); }
    public GPLENStatus GPIO17 { get => (GPLENStatus)(_innerValue & (1u << 17)); set => _innerValue = _innerValue & ~(1u << 17) | (((uint)value & 0b1) << 17); }
    public GPLENStatus GPIO18 { get => (GPLENStatus)(_innerValue & (1u << 18)); set => _innerValue = _innerValue & ~(1u << 18) | (((uint)value & 0b1) << 18); }
    public GPLENStatus GPIO19 { get => (GPLENStatus)(_innerValue & (1u << 19)); set => _innerValue = _innerValue & ~(1u << 19) | (((uint)value & 0b1) << 19); }
    public GPLENStatus GPIO20 { get => (GPLENStatus)(_innerValue & (1u << 20)); set => _innerValue = _innerValue & ~(1u << 20) | (((uint)value & 0b1) << 20); }
    public GPLENStatus GPIO21 { get => (GPLENStatus)(_innerValue & (1u << 21)); set => _innerValue = _innerValue & ~(1u << 21) | (((uint)value & 0b1) << 21); }
    public GPLENStatus GPIO22 { get => (GPLENStatus)(_innerValue & (1u << 22)); set => _innerValue = _innerValue & ~(1u << 22) | (((uint)value & 0b1) << 22); }
    public GPLENStatus GPIO23 { get => (GPLENStatus)(_innerValue & (1u << 23)); set => _innerValue = _innerValue & ~(1u << 23) | (((uint)value & 0b1) << 23); }
    public GPLENStatus GPIO24 { get => (GPLENStatus)(_innerValue & (1u << 24)); set => _innerValue = _innerValue & ~(1u << 24) | (((uint)value & 0b1) << 24); }
    public GPLENStatus GPIO25 { get => (GPLENStatus)(_innerValue & (1u << 25)); set => _innerValue = _innerValue & ~(1u << 25) | (((uint)value & 0b1) << 25); }
    public GPLENStatus GPIO26 { get => (GPLENStatus)(_innerValue & (1u << 26)); set => _innerValue = _innerValue & ~(1u << 26) | (((uint)value & 0b1) << 26); }
    public GPLENStatus GPIO27 { get => (GPLENStatus)(_innerValue & (1u << 27)); set => _innerValue = _innerValue & ~(1u << 27) | (((uint)value & 0b1) << 27); }
    public GPLENStatus GPIO28 { get => (GPLENStatus)(_innerValue & (1u << 28)); set => _innerValue = _innerValue & ~(1u << 28) | (((uint)value & 0b1) << 28); }
    public GPLENStatus GPIO29 { get => (GPLENStatus)(_innerValue & (1u << 29)); set => _innerValue = _innerValue & ~(1u << 29) | (((uint)value & 0b1) << 29); }
    public GPLENStatus GPIO30 { get => (GPLENStatus)(_innerValue & (1u << 30)); set => _innerValue = _innerValue & ~(1u << 30) | (((uint)value & 0b1) << 30); }
    public GPLENStatus GPIO31 { get => (GPLENStatus)(_innerValue & (1u << 31)); set => _innerValue = _innerValue & ~(1u << 31) | (((uint)value & 0b1) << 31); }
}
public struct GPLEN1
{
    private uint _innerValue;
    public GPLENStatus GPIO32 { get => (GPLENStatus)(_innerValue & (1u << 0)); set => _innerValue = _innerValue & ~(1u << 0) | (((uint)value & 0b1) << 0); }
    public GPLENStatus GPIO33 { get => (GPLENStatus)(_innerValue & (1u << 1)); set => _innerValue = _innerValue & ~(1u << 1) | (((uint)value & 0b1) << 1); }
    public GPLENStatus GPIO34 { get => (GPLENStatus)(_innerValue & (1u << 2)); set => _innerValue = _innerValue & ~(1u << 2) | (((uint)value & 0b1) << 2); }
    public GPLENStatus GPIO35 { get => (GPLENStatus)(_innerValue & (1u << 3)); set => _innerValue = _innerValue & ~(1u << 3) | (((uint)value & 0b1) << 3); }
    public GPLENStatus GPIO36 { get => (GPLENStatus)(_innerValue & (1u << 4)); set => _innerValue = _innerValue & ~(1u << 4) | (((uint)value & 0b1) << 4); }
    public GPLENStatus GPIO37 { get => (GPLENStatus)(_innerValue & (1u << 5)); set => _innerValue = _innerValue & ~(1u << 5) | (((uint)value & 0b1) << 5); }
    public GPLENStatus GPIO38 { get => (GPLENStatus)(_innerValue & (1u << 6)); set => _innerValue = _innerValue & ~(1u << 6) | (((uint)value & 0b1) << 6); }
    public GPLENStatus GPIO39 { get => (GPLENStatus)(_innerValue & (1u << 7)); set => _innerValue = _innerValue & ~(1u << 7) | (((uint)value & 0b1) << 7); }
    public GPLENStatus GPIO40 { get => (GPLENStatus)(_innerValue & (1u << 8)); set => _innerValue = _innerValue & ~(1u << 8) | (((uint)value & 0b1) << 8); }
    public GPLENStatus GPIO41 { get => (GPLENStatus)(_innerValue & (1u << 9)); set => _innerValue = _innerValue & ~(1u << 9) | (((uint)value & 0b1) << 9); }
    public GPLENStatus GPIO42 { get => (GPLENStatus)(_innerValue & (1u << 10)); set => _innerValue = _innerValue & ~(1u << 10) | (((uint)value & 0b1) << 10); }
    public GPLENStatus GPIO43 { get => (GPLENStatus)(_innerValue & (1u << 11)); set => _innerValue = _innerValue & ~(1u << 11) | (((uint)value & 0b1) << 11); }
    public GPLENStatus GPIO44 { get => (GPLENStatus)(_innerValue & (1u << 12)); set => _innerValue = _innerValue & ~(1u << 12) | (((uint)value & 0b1) << 12); }
    public GPLENStatus GPIO45 { get => (GPLENStatus)(_innerValue & (1u << 13)); set => _innerValue = _innerValue & ~(1u << 13) | (((uint)value & 0b1) << 13); }
    public GPLENStatus GPIO46 { get => (GPLENStatus)(_innerValue & (1u << 14)); set => _innerValue = _innerValue & ~(1u << 14) | (((uint)value & 0b1) << 14); }
    public GPLENStatus GPIO47 { get => (GPLENStatus)(_innerValue & (1u << 15)); set => _innerValue = _innerValue & ~(1u << 15) | (((uint)value & 0b1) << 15); }
    public GPLENStatus GPIO48 { get => (GPLENStatus)(_innerValue & (1u << 16)); set => _innerValue = _innerValue & ~(1u << 16) | (((uint)value & 0b1) << 16); }
    public GPLENStatus GPIO49 { get => (GPLENStatus)(_innerValue & (1u << 17)); set => _innerValue = _innerValue & ~(1u << 17) | (((uint)value & 0b1) << 17); }
    public GPLENStatus GPIO50 { get => (GPLENStatus)(_innerValue & (1u << 18)); set => _innerValue = _innerValue & ~(1u << 18) | (((uint)value & 0b1) << 18); }
    public GPLENStatus GPIO51 { get => (GPLENStatus)(_innerValue & (1u << 19)); set => _innerValue = _innerValue & ~(1u << 19) | (((uint)value & 0b1) << 19); }
    public GPLENStatus GPIO52 { get => (GPLENStatus)(_innerValue & (1u << 20)); set => _innerValue = _innerValue & ~(1u << 20) | (((uint)value & 0b1) << 20); }
    public GPLENStatus GPIO53 { get => (GPLENStatus)(_innerValue & (1u << 21)); set => _innerValue = _innerValue & ~(1u << 21) | (((uint)value & 0b1) << 21); }
    public GPLENStatus GPIO54 { get => (GPLENStatus)(_innerValue & (1u << 22)); set => _innerValue = _innerValue & ~(1u << 22) | (((uint)value & 0b1) << 22); }
    public GPLENStatus GPIO55 { get => (GPLENStatus)(_innerValue & (1u << 23)); set => _innerValue = _innerValue & ~(1u << 23) | (((uint)value & 0b1) << 23); }
    public GPLENStatus GPIO56 { get => (GPLENStatus)(_innerValue & (1u << 24)); set => _innerValue = _innerValue & ~(1u << 24) | (((uint)value & 0b1) << 24); }
    public GPLENStatus GPIO57 { get => (GPLENStatus)(_innerValue & (1u << 25)); set => _innerValue = _innerValue & ~(1u << 25) | (((uint)value & 0b1) << 25); }
}


public enum GPARENStatus
{
    /// <summary>
    /// Asynchronous rising edge detect disabled on GPIO pin n
    /// </summary>
    AsynchronousRisingEdgeDetectDisabled = 0,
    /// <summary>
    /// Asynchronous rising edge on GPIO pin n sets corresponding bit in GPEDS0
    /// </summary>
    AsynchronousRisingEdgeDetectOn = 1
}
public struct GPAREN0
{
    private uint _innerValue;
    public GPARENStatus GPIO00 { get => (GPARENStatus)(_innerValue & (1u << 0)); set => _innerValue = _innerValue & ~(1u << 0) | (((uint)value & 0b1) << 0); }
    public GPARENStatus GPIO01 { get => (GPARENStatus)(_innerValue & (1u << 1)); set => _innerValue = _innerValue & ~(1u << 1) | (((uint)value & 0b1) << 1); }
    public GPARENStatus GPIO02 { get => (GPARENStatus)(_innerValue & (1u << 2)); set => _innerValue = _innerValue & ~(1u << 2) | (((uint)value & 0b1) << 2); }
    public GPARENStatus GPIO03 { get => (GPARENStatus)(_innerValue & (1u << 3)); set => _innerValue = _innerValue & ~(1u << 3) | (((uint)value & 0b1) << 3); }
    public GPARENStatus GPIO04 { get => (GPARENStatus)(_innerValue & (1u << 4)); set => _innerValue = _innerValue & ~(1u << 4) | (((uint)value & 0b1) << 4); }
    public GPARENStatus GPIO05 { get => (GPARENStatus)(_innerValue & (1u << 5)); set => _innerValue = _innerValue & ~(1u << 5) | (((uint)value & 0b1) << 5); }
    public GPARENStatus GPIO06 { get => (GPARENStatus)(_innerValue & (1u << 6)); set => _innerValue = _innerValue & ~(1u << 6) | (((uint)value & 0b1) << 6); }
    public GPARENStatus GPIO07 { get => (GPARENStatus)(_innerValue & (1u << 7)); set => _innerValue = _innerValue & ~(1u << 7) | (((uint)value & 0b1) << 7); }
    public GPARENStatus GPIO08 { get => (GPARENStatus)(_innerValue & (1u << 8)); set => _innerValue = _innerValue & ~(1u << 8) | (((uint)value & 0b1) << 8); }
    public GPARENStatus GPIO09 { get => (GPARENStatus)(_innerValue & (1u << 9)); set => _innerValue = _innerValue & ~(1u << 9) | (((uint)value & 0b1) << 9); }
    public GPARENStatus GPIO10 { get => (GPARENStatus)(_innerValue & (1u << 10)); set => _innerValue = _innerValue & ~(1u << 10) | (((uint)value & 0b1) << 10); }
    public GPARENStatus GPIO11 { get => (GPARENStatus)(_innerValue & (1u << 11)); set => _innerValue = _innerValue & ~(1u << 11) | (((uint)value & 0b1) << 11); }
    public GPARENStatus GPIO12 { get => (GPARENStatus)(_innerValue & (1u << 12)); set => _innerValue = _innerValue & ~(1u << 12) | (((uint)value & 0b1) << 12); }
    public GPARENStatus GPIO13 { get => (GPARENStatus)(_innerValue & (1u << 13)); set => _innerValue = _innerValue & ~(1u << 13) | (((uint)value & 0b1) << 13); }
    public GPARENStatus GPIO14 { get => (GPARENStatus)(_innerValue & (1u << 14)); set => _innerValue = _innerValue & ~(1u << 14) | (((uint)value & 0b1) << 14); }
    public GPARENStatus GPIO15 { get => (GPARENStatus)(_innerValue & (1u << 15)); set => _innerValue = _innerValue & ~(1u << 15) | (((uint)value & 0b1) << 15); }
    public GPARENStatus GPIO16 { get => (GPARENStatus)(_innerValue & (1u << 16)); set => _innerValue = _innerValue & ~(1u << 16) | (((uint)value & 0b1) << 16); }
    public GPARENStatus GPIO17 { get => (GPARENStatus)(_innerValue & (1u << 17)); set => _innerValue = _innerValue & ~(1u << 17) | (((uint)value & 0b1) << 17); }
    public GPARENStatus GPIO18 { get => (GPARENStatus)(_innerValue & (1u << 18)); set => _innerValue = _innerValue & ~(1u << 18) | (((uint)value & 0b1) << 18); }
    public GPARENStatus GPIO19 { get => (GPARENStatus)(_innerValue & (1u << 19)); set => _innerValue = _innerValue & ~(1u << 19) | (((uint)value & 0b1) << 19); }
    public GPARENStatus GPIO20 { get => (GPARENStatus)(_innerValue & (1u << 20)); set => _innerValue = _innerValue & ~(1u << 20) | (((uint)value & 0b1) << 20); }
    public GPARENStatus GPIO21 { get => (GPARENStatus)(_innerValue & (1u << 21)); set => _innerValue = _innerValue & ~(1u << 21) | (((uint)value & 0b1) << 21); }
    public GPARENStatus GPIO22 { get => (GPARENStatus)(_innerValue & (1u << 22)); set => _innerValue = _innerValue & ~(1u << 22) | (((uint)value & 0b1) << 22); }
    public GPARENStatus GPIO23 { get => (GPARENStatus)(_innerValue & (1u << 23)); set => _innerValue = _innerValue & ~(1u << 23) | (((uint)value & 0b1) << 23); }
    public GPARENStatus GPIO24 { get => (GPARENStatus)(_innerValue & (1u << 24)); set => _innerValue = _innerValue & ~(1u << 24) | (((uint)value & 0b1) << 24); }
    public GPARENStatus GPIO25 { get => (GPARENStatus)(_innerValue & (1u << 25)); set => _innerValue = _innerValue & ~(1u << 25) | (((uint)value & 0b1) << 25); }
    public GPARENStatus GPIO26 { get => (GPARENStatus)(_innerValue & (1u << 26)); set => _innerValue = _innerValue & ~(1u << 26) | (((uint)value & 0b1) << 26); }
    public GPARENStatus GPIO27 { get => (GPARENStatus)(_innerValue & (1u << 27)); set => _innerValue = _innerValue & ~(1u << 27) | (((uint)value & 0b1) << 27); }
    public GPARENStatus GPIO28 { get => (GPARENStatus)(_innerValue & (1u << 28)); set => _innerValue = _innerValue & ~(1u << 28) | (((uint)value & 0b1) << 28); }
    public GPARENStatus GPIO29 { get => (GPARENStatus)(_innerValue & (1u << 29)); set => _innerValue = _innerValue & ~(1u << 29) | (((uint)value & 0b1) << 29); }
    public GPARENStatus GPIO30 { get => (GPARENStatus)(_innerValue & (1u << 30)); set => _innerValue = _innerValue & ~(1u << 30) | (((uint)value & 0b1) << 30); }
    public GPARENStatus GPIO31 { get => (GPARENStatus)(_innerValue & (1u << 31)); set => _innerValue = _innerValue & ~(1u << 31) | (((uint)value & 0b1) << 31); }
}
public struct GPAREN1
{
    private uint _innerValue;
    public GPARENStatus GPIO32 { get => (GPARENStatus)(_innerValue & (1u << 0)); set => _innerValue = _innerValue & ~(1u << 0) | (((uint)value & 0b1) << 0); }
    public GPARENStatus GPIO33 { get => (GPARENStatus)(_innerValue & (1u << 1)); set => _innerValue = _innerValue & ~(1u << 1) | (((uint)value & 0b1) << 1); }
    public GPARENStatus GPIO34 { get => (GPARENStatus)(_innerValue & (1u << 2)); set => _innerValue = _innerValue & ~(1u << 2) | (((uint)value & 0b1) << 2); }
    public GPARENStatus GPIO35 { get => (GPARENStatus)(_innerValue & (1u << 3)); set => _innerValue = _innerValue & ~(1u << 3) | (((uint)value & 0b1) << 3); }
    public GPARENStatus GPIO36 { get => (GPARENStatus)(_innerValue & (1u << 4)); set => _innerValue = _innerValue & ~(1u << 4) | (((uint)value & 0b1) << 4); }
    public GPARENStatus GPIO37 { get => (GPARENStatus)(_innerValue & (1u << 5)); set => _innerValue = _innerValue & ~(1u << 5) | (((uint)value & 0b1) << 5); }
    public GPARENStatus GPIO38 { get => (GPARENStatus)(_innerValue & (1u << 6)); set => _innerValue = _innerValue & ~(1u << 6) | (((uint)value & 0b1) << 6); }
    public GPARENStatus GPIO39 { get => (GPARENStatus)(_innerValue & (1u << 7)); set => _innerValue = _innerValue & ~(1u << 7) | (((uint)value & 0b1) << 7); }
    public GPARENStatus GPIO40 { get => (GPARENStatus)(_innerValue & (1u << 8)); set => _innerValue = _innerValue & ~(1u << 8) | (((uint)value & 0b1) << 8); }
    public GPARENStatus GPIO41 { get => (GPARENStatus)(_innerValue & (1u << 9)); set => _innerValue = _innerValue & ~(1u << 9) | (((uint)value & 0b1) << 9); }
    public GPARENStatus GPIO42 { get => (GPARENStatus)(_innerValue & (1u << 10)); set => _innerValue = _innerValue & ~(1u << 10) | (((uint)value & 0b1) << 10); }
    public GPARENStatus GPIO43 { get => (GPARENStatus)(_innerValue & (1u << 11)); set => _innerValue = _innerValue & ~(1u << 11) | (((uint)value & 0b1) << 11); }
    public GPARENStatus GPIO44 { get => (GPARENStatus)(_innerValue & (1u << 12)); set => _innerValue = _innerValue & ~(1u << 12) | (((uint)value & 0b1) << 12); }
    public GPARENStatus GPIO45 { get => (GPARENStatus)(_innerValue & (1u << 13)); set => _innerValue = _innerValue & ~(1u << 13) | (((uint)value & 0b1) << 13); }
    public GPARENStatus GPIO46 { get => (GPARENStatus)(_innerValue & (1u << 14)); set => _innerValue = _innerValue & ~(1u << 14) | (((uint)value & 0b1) << 14); }
    public GPARENStatus GPIO47 { get => (GPARENStatus)(_innerValue & (1u << 15)); set => _innerValue = _innerValue & ~(1u << 15) | (((uint)value & 0b1) << 15); }
    public GPARENStatus GPIO48 { get => (GPARENStatus)(_innerValue & (1u << 16)); set => _innerValue = _innerValue & ~(1u << 16) | (((uint)value & 0b1) << 16); }
    public GPARENStatus GPIO49 { get => (GPARENStatus)(_innerValue & (1u << 17)); set => _innerValue = _innerValue & ~(1u << 17) | (((uint)value & 0b1) << 17); }
    public GPARENStatus GPIO50 { get => (GPARENStatus)(_innerValue & (1u << 18)); set => _innerValue = _innerValue & ~(1u << 18) | (((uint)value & 0b1) << 18); }
    public GPARENStatus GPIO51 { get => (GPARENStatus)(_innerValue & (1u << 19)); set => _innerValue = _innerValue & ~(1u << 19) | (((uint)value & 0b1) << 19); }
    public GPARENStatus GPIO52 { get => (GPARENStatus)(_innerValue & (1u << 20)); set => _innerValue = _innerValue & ~(1u << 20) | (((uint)value & 0b1) << 20); }
    public GPARENStatus GPIO53 { get => (GPARENStatus)(_innerValue & (1u << 21)); set => _innerValue = _innerValue & ~(1u << 21) | (((uint)value & 0b1) << 21); }
    public GPARENStatus GPIO54 { get => (GPARENStatus)(_innerValue & (1u << 22)); set => _innerValue = _innerValue & ~(1u << 22) | (((uint)value & 0b1) << 22); }
    public GPARENStatus GPIO55 { get => (GPARENStatus)(_innerValue & (1u << 23)); set => _innerValue = _innerValue & ~(1u << 23) | (((uint)value & 0b1) << 23); }
    public GPARENStatus GPIO56 { get => (GPARENStatus)(_innerValue & (1u << 24)); set => _innerValue = _innerValue & ~(1u << 24) | (((uint)value & 0b1) << 24); }
    public GPARENStatus GPIO57 { get => (GPARENStatus)(_innerValue & (1u << 25)); set => _innerValue = _innerValue & ~(1u << 25) | (((uint)value & 0b1) << 25); }
}


public enum GPAFENStatus
{
    /// <summary>
    /// Asynchronous rising edge detect disabled on GPIO pin n
    /// </summary>
    AsynchronousFallingEdgeDetectDisabled = 0,
    /// <summary>
    /// Asynchronous rising edge on GPIO pin n sets corresponding bit in GPEDS0
    /// </summary>
    AsynchronousFallingEdgeDetectOn = 1
}
public struct GPAFEN0
{
    private uint _innerValue;
    public GPAFENStatus GPIO00 { get => (GPAFENStatus)(_innerValue & (1u << 0)); set => _innerValue = _innerValue & ~(1u << 0) | (((uint)value & 0b1) << 0); }
    public GPAFENStatus GPIO01 { get => (GPAFENStatus)(_innerValue & (1u << 1)); set => _innerValue = _innerValue & ~(1u << 1) | (((uint)value & 0b1) << 1); }
    public GPAFENStatus GPIO02 { get => (GPAFENStatus)(_innerValue & (1u << 2)); set => _innerValue = _innerValue & ~(1u << 2) | (((uint)value & 0b1) << 2); }
    public GPAFENStatus GPIO03 { get => (GPAFENStatus)(_innerValue & (1u << 3)); set => _innerValue = _innerValue & ~(1u << 3) | (((uint)value & 0b1) << 3); }
    public GPAFENStatus GPIO04 { get => (GPAFENStatus)(_innerValue & (1u << 4)); set => _innerValue = _innerValue & ~(1u << 4) | (((uint)value & 0b1) << 4); }
    public GPAFENStatus GPIO05 { get => (GPAFENStatus)(_innerValue & (1u << 5)); set => _innerValue = _innerValue & ~(1u << 5) | (((uint)value & 0b1) << 5); }
    public GPAFENStatus GPIO06 { get => (GPAFENStatus)(_innerValue & (1u << 6)); set => _innerValue = _innerValue & ~(1u << 6) | (((uint)value & 0b1) << 6); }
    public GPAFENStatus GPIO07 { get => (GPAFENStatus)(_innerValue & (1u << 7)); set => _innerValue = _innerValue & ~(1u << 7) | (((uint)value & 0b1) << 7); }
    public GPAFENStatus GPIO08 { get => (GPAFENStatus)(_innerValue & (1u << 8)); set => _innerValue = _innerValue & ~(1u << 8) | (((uint)value & 0b1) << 8); }
    public GPAFENStatus GPIO09 { get => (GPAFENStatus)(_innerValue & (1u << 9)); set => _innerValue = _innerValue & ~(1u << 9) | (((uint)value & 0b1) << 9); }
    public GPAFENStatus GPIO10 { get => (GPAFENStatus)(_innerValue & (1u << 10)); set => _innerValue = _innerValue & ~(1u << 10) | (((uint)value & 0b1) << 10); }
    public GPAFENStatus GPIO11 { get => (GPAFENStatus)(_innerValue & (1u << 11)); set => _innerValue = _innerValue & ~(1u << 11) | (((uint)value & 0b1) << 11); }
    public GPAFENStatus GPIO12 { get => (GPAFENStatus)(_innerValue & (1u << 12)); set => _innerValue = _innerValue & ~(1u << 12) | (((uint)value & 0b1) << 12); }
    public GPAFENStatus GPIO13 { get => (GPAFENStatus)(_innerValue & (1u << 13)); set => _innerValue = _innerValue & ~(1u << 13) | (((uint)value & 0b1) << 13); }
    public GPAFENStatus GPIO14 { get => (GPAFENStatus)(_innerValue & (1u << 14)); set => _innerValue = _innerValue & ~(1u << 14) | (((uint)value & 0b1) << 14); }
    public GPAFENStatus GPIO15 { get => (GPAFENStatus)(_innerValue & (1u << 15)); set => _innerValue = _innerValue & ~(1u << 15) | (((uint)value & 0b1) << 15); }
    public GPAFENStatus GPIO16 { get => (GPAFENStatus)(_innerValue & (1u << 16)); set => _innerValue = _innerValue & ~(1u << 16) | (((uint)value & 0b1) << 16); }
    public GPAFENStatus GPIO17 { get => (GPAFENStatus)(_innerValue & (1u << 17)); set => _innerValue = _innerValue & ~(1u << 17) | (((uint)value & 0b1) << 17); }
    public GPAFENStatus GPIO18 { get => (GPAFENStatus)(_innerValue & (1u << 18)); set => _innerValue = _innerValue & ~(1u << 18) | (((uint)value & 0b1) << 18); }
    public GPAFENStatus GPIO19 { get => (GPAFENStatus)(_innerValue & (1u << 19)); set => _innerValue = _innerValue & ~(1u << 19) | (((uint)value & 0b1) << 19); }
    public GPAFENStatus GPIO20 { get => (GPAFENStatus)(_innerValue & (1u << 20)); set => _innerValue = _innerValue & ~(1u << 20) | (((uint)value & 0b1) << 20); }
    public GPAFENStatus GPIO21 { get => (GPAFENStatus)(_innerValue & (1u << 21)); set => _innerValue = _innerValue & ~(1u << 21) | (((uint)value & 0b1) << 21); }
    public GPAFENStatus GPIO22 { get => (GPAFENStatus)(_innerValue & (1u << 22)); set => _innerValue = _innerValue & ~(1u << 22) | (((uint)value & 0b1) << 22); }
    public GPAFENStatus GPIO23 { get => (GPAFENStatus)(_innerValue & (1u << 23)); set => _innerValue = _innerValue & ~(1u << 23) | (((uint)value & 0b1) << 23); }
    public GPAFENStatus GPIO24 { get => (GPAFENStatus)(_innerValue & (1u << 24)); set => _innerValue = _innerValue & ~(1u << 24) | (((uint)value & 0b1) << 24); }
    public GPAFENStatus GPIO25 { get => (GPAFENStatus)(_innerValue & (1u << 25)); set => _innerValue = _innerValue & ~(1u << 25) | (((uint)value & 0b1) << 25); }
    public GPAFENStatus GPIO26 { get => (GPAFENStatus)(_innerValue & (1u << 26)); set => _innerValue = _innerValue & ~(1u << 26) | (((uint)value & 0b1) << 26); }
    public GPAFENStatus GPIO27 { get => (GPAFENStatus)(_innerValue & (1u << 27)); set => _innerValue = _innerValue & ~(1u << 27) | (((uint)value & 0b1) << 27); }
    public GPAFENStatus GPIO28 { get => (GPAFENStatus)(_innerValue & (1u << 28)); set => _innerValue = _innerValue & ~(1u << 28) | (((uint)value & 0b1) << 28); }
    public GPAFENStatus GPIO29 { get => (GPAFENStatus)(_innerValue & (1u << 29)); set => _innerValue = _innerValue & ~(1u << 29) | (((uint)value & 0b1) << 29); }
    public GPAFENStatus GPIO30 { get => (GPAFENStatus)(_innerValue & (1u << 30)); set => _innerValue = _innerValue & ~(1u << 30) | (((uint)value & 0b1) << 30); }
    public GPAFENStatus GPIO31 { get => (GPAFENStatus)(_innerValue & (1u << 31)); set => _innerValue = _innerValue & ~(1u << 31) | (((uint)value & 0b1) << 31); }
}
public struct GPAFEN1
{
    private uint _innerValue;
    public GPAFENStatus GPIO32 { get => (GPAFENStatus)(_innerValue & (1u << 0)); set => _innerValue = _innerValue & ~(1u << 0) | (((uint)value & 0b1) << 0); }
    public GPAFENStatus GPIO33 { get => (GPAFENStatus)(_innerValue & (1u << 1)); set => _innerValue = _innerValue & ~(1u << 1) | (((uint)value & 0b1) << 1); }
    public GPAFENStatus GPIO34 { get => (GPAFENStatus)(_innerValue & (1u << 2)); set => _innerValue = _innerValue & ~(1u << 2) | (((uint)value & 0b1) << 2); }
    public GPAFENStatus GPIO35 { get => (GPAFENStatus)(_innerValue & (1u << 3)); set => _innerValue = _innerValue & ~(1u << 3) | (((uint)value & 0b1) << 3); }
    public GPAFENStatus GPIO36 { get => (GPAFENStatus)(_innerValue & (1u << 4)); set => _innerValue = _innerValue & ~(1u << 4) | (((uint)value & 0b1) << 4); }
    public GPAFENStatus GPIO37 { get => (GPAFENStatus)(_innerValue & (1u << 5)); set => _innerValue = _innerValue & ~(1u << 5) | (((uint)value & 0b1) << 5); }
    public GPAFENStatus GPIO38 { get => (GPAFENStatus)(_innerValue & (1u << 6)); set => _innerValue = _innerValue & ~(1u << 6) | (((uint)value & 0b1) << 6); }
    public GPAFENStatus GPIO39 { get => (GPAFENStatus)(_innerValue & (1u << 7)); set => _innerValue = _innerValue & ~(1u << 7) | (((uint)value & 0b1) << 7); }
    public GPAFENStatus GPIO40 { get => (GPAFENStatus)(_innerValue & (1u << 8)); set => _innerValue = _innerValue & ~(1u << 8) | (((uint)value & 0b1) << 8); }
    public GPAFENStatus GPIO41 { get => (GPAFENStatus)(_innerValue & (1u << 9)); set => _innerValue = _innerValue & ~(1u << 9) | (((uint)value & 0b1) << 9); }
    public GPAFENStatus GPIO42 { get => (GPAFENStatus)(_innerValue & (1u << 10)); set => _innerValue = _innerValue & ~(1u << 10) | (((uint)value & 0b1) << 10); }
    public GPAFENStatus GPIO43 { get => (GPAFENStatus)(_innerValue & (1u << 11)); set => _innerValue = _innerValue & ~(1u << 11) | (((uint)value & 0b1) << 11); }
    public GPAFENStatus GPIO44 { get => (GPAFENStatus)(_innerValue & (1u << 12)); set => _innerValue = _innerValue & ~(1u << 12) | (((uint)value & 0b1) << 12); }
    public GPAFENStatus GPIO45 { get => (GPAFENStatus)(_innerValue & (1u << 13)); set => _innerValue = _innerValue & ~(1u << 13) | (((uint)value & 0b1) << 13); }
    public GPAFENStatus GPIO46 { get => (GPAFENStatus)(_innerValue & (1u << 14)); set => _innerValue = _innerValue & ~(1u << 14) | (((uint)value & 0b1) << 14); }
    public GPAFENStatus GPIO47 { get => (GPAFENStatus)(_innerValue & (1u << 15)); set => _innerValue = _innerValue & ~(1u << 15) | (((uint)value & 0b1) << 15); }
    public GPAFENStatus GPIO48 { get => (GPAFENStatus)(_innerValue & (1u << 16)); set => _innerValue = _innerValue & ~(1u << 16) | (((uint)value & 0b1) << 16); }
    public GPAFENStatus GPIO49 { get => (GPAFENStatus)(_innerValue & (1u << 17)); set => _innerValue = _innerValue & ~(1u << 17) | (((uint)value & 0b1) << 17); }
    public GPAFENStatus GPIO50 { get => (GPAFENStatus)(_innerValue & (1u << 18)); set => _innerValue = _innerValue & ~(1u << 18) | (((uint)value & 0b1) << 18); }
    public GPAFENStatus GPIO51 { get => (GPAFENStatus)(_innerValue & (1u << 19)); set => _innerValue = _innerValue & ~(1u << 19) | (((uint)value & 0b1) << 19); }
    public GPAFENStatus GPIO52 { get => (GPAFENStatus)(_innerValue & (1u << 20)); set => _innerValue = _innerValue & ~(1u << 20) | (((uint)value & 0b1) << 20); }
    public GPAFENStatus GPIO53 { get => (GPAFENStatus)(_innerValue & (1u << 21)); set => _innerValue = _innerValue & ~(1u << 21) | (((uint)value & 0b1) << 21); }
    public GPAFENStatus GPIO54 { get => (GPAFENStatus)(_innerValue & (1u << 22)); set => _innerValue = _innerValue & ~(1u << 22) | (((uint)value & 0b1) << 22); }
    public GPAFENStatus GPIO55 { get => (GPAFENStatus)(_innerValue & (1u << 23)); set => _innerValue = _innerValue & ~(1u << 23) | (((uint)value & 0b1) << 23); }
    public GPAFENStatus GPIO56 { get => (GPAFENStatus)(_innerValue & (1u << 24)); set => _innerValue = _innerValue & ~(1u << 24) | (((uint)value & 0b1) << 24); }
    public GPAFENStatus GPIO57 { get => (GPAFENStatus)(_innerValue & (1u << 25)); set => _innerValue = _innerValue & ~(1u << 25) | (((uint)value & 0b1) << 25); }
}

public enum GPIO_PUP_PDN_CNTRLStatus
{
    NoResistorIsSelected = 0b00,
    PullUpResistorIsSelected = 0b01,
    PullDownResistorIsSelected = 0b10,
    Reserved = 0b11,
}

public struct GPIO_PUP_PDN_CNTRL_REG0
{
    private uint _innerValue;
    public GPIO_PUP_PDN_CNTRLStatus GPIO00 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 <<  0)); set => _innerValue = _innerValue & ~(0b11u <<  0) | (((uint)value & 0b11) <<  0); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO01 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 <<  2)); set => _innerValue = _innerValue & ~(0b11u <<  2) | (((uint)value & 0b11) <<  2); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO02 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 <<  4)); set => _innerValue = _innerValue & ~(0b11u <<  4) | (((uint)value & 0b11) <<  4); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO03 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 <<  6)); set => _innerValue = _innerValue & ~(0b11u <<  6) | (((uint)value & 0b11) <<  6); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO04 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 <<  8)); set => _innerValue = _innerValue & ~(0b11u <<  8) | (((uint)value & 0b11) <<  8); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO05 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 10)); set => _innerValue = _innerValue & ~(0b11u << 10) | (((uint)value & 0b11) << 10); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO06 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 12)); set => _innerValue = _innerValue & ~(0b11u << 12) | (((uint)value & 0b11) << 12); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO07 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 14)); set => _innerValue = _innerValue & ~(0b11u << 14) | (((uint)value & 0b11) << 14); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO08 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 16)); set => _innerValue = _innerValue & ~(0b11u << 16) | (((uint)value & 0b11) << 16); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO09 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 18)); set => _innerValue = _innerValue & ~(0b11u << 18) | (((uint)value & 0b11) << 18); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO10 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 20)); set => _innerValue = _innerValue & ~(0b11u << 20) | (((uint)value & 0b11) << 20); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO11 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 22)); set => _innerValue = _innerValue & ~(0b11u << 22) | (((uint)value & 0b11) << 22); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO12 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 24)); set => _innerValue = _innerValue & ~(0b11u << 24) | (((uint)value & 0b11) << 24); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO13 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 26)); set => _innerValue = _innerValue & ~(0b11u << 26) | (((uint)value & 0b11) << 26); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO14 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 28)); set => _innerValue = _innerValue & ~(0b11u << 28) | (((uint)value & 0b11) << 28); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO15 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 20)); set => _innerValue = _innerValue & ~(0b11u << 20) | (((uint)value & 0b11) << 20); }
}

public struct GPIO_PUP_PDN_CNTRL_REG1
{
    private uint _innerValue;
    public GPIO_PUP_PDN_CNTRLStatus GPIO16 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 0)); set => _innerValue = _innerValue & ~(0b11u << 0) | (((uint)value & 0b11) << 0); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO17 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 2)); set => _innerValue = _innerValue & ~(0b11u << 2) | (((uint)value & 0b11) << 2); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO18 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 4)); set => _innerValue = _innerValue & ~(0b11u << 4) | (((uint)value & 0b11) << 4); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO19 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 6)); set => _innerValue = _innerValue & ~(0b11u << 6) | (((uint)value & 0b11) << 6); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO20 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 8)); set => _innerValue = _innerValue & ~(0b11u << 8) | (((uint)value & 0b11) << 8); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO21 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 10)); set => _innerValue = _innerValue & ~(0b11u << 10) | (((uint)value & 0b11) << 10); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO22 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 12)); set => _innerValue = _innerValue & ~(0b11u << 12) | (((uint)value & 0b11) << 12); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO23 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 14)); set => _innerValue = _innerValue & ~(0b11u << 14) | (((uint)value & 0b11) << 14); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO24 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 16)); set => _innerValue = _innerValue & ~(0b11u << 16) | (((uint)value & 0b11) << 16); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO25 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 18)); set => _innerValue = _innerValue & ~(0b11u << 18) | (((uint)value & 0b11) << 18); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO26 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 20)); set => _innerValue = _innerValue & ~(0b11u << 20) | (((uint)value & 0b11) << 20); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO27 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 22)); set => _innerValue = _innerValue & ~(0b11u << 22) | (((uint)value & 0b11) << 22); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO28 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 24)); set => _innerValue = _innerValue & ~(0b11u << 24) | (((uint)value & 0b11) << 24); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO29 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 26)); set => _innerValue = _innerValue & ~(0b11u << 26) | (((uint)value & 0b11) << 26); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO30 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 28)); set => _innerValue = _innerValue & ~(0b11u << 28) | (((uint)value & 0b11) << 28); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO31 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 20)); set => _innerValue = _innerValue & ~(0b11u << 20) | (((uint)value & 0b11) << 20); }
}

public struct GPIO_PUP_PDN_CNTRL_REG2
{
    private uint _innerValue;
    public GPIO_PUP_PDN_CNTRLStatus GPIO32 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 0)); set => _innerValue = _innerValue & ~(0b11u << 0) | (((uint)value & 0b11) << 0); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO33 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 2)); set => _innerValue = _innerValue & ~(0b11u << 2) | (((uint)value & 0b11) << 2); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO34 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 4)); set => _innerValue = _innerValue & ~(0b11u << 4) | (((uint)value & 0b11) << 4); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO35 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 6)); set => _innerValue = _innerValue & ~(0b11u << 6) | (((uint)value & 0b11) << 6); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO36 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 8)); set => _innerValue = _innerValue & ~(0b11u << 8) | (((uint)value & 0b11) << 8); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO37 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 10)); set => _innerValue = _innerValue & ~(0b11u << 10) | (((uint)value & 0b11) << 10); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO38 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 12)); set => _innerValue = _innerValue & ~(0b11u << 12) | (((uint)value & 0b11) << 12); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO39 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 14)); set => _innerValue = _innerValue & ~(0b11u << 14) | (((uint)value & 0b11) << 14); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO40 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 16)); set => _innerValue = _innerValue & ~(0b11u << 16) | (((uint)value & 0b11) << 16); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO41 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 18)); set => _innerValue = _innerValue & ~(0b11u << 18) | (((uint)value & 0b11) << 18); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO42 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 20)); set => _innerValue = _innerValue & ~(0b11u << 20) | (((uint)value & 0b11) << 20); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO43 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 22)); set => _innerValue = _innerValue & ~(0b11u << 22) | (((uint)value & 0b11) << 22); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO44 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 24)); set => _innerValue = _innerValue & ~(0b11u << 24) | (((uint)value & 0b11) << 24); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO45 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 26)); set => _innerValue = _innerValue & ~(0b11u << 26) | (((uint)value & 0b11) << 26); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO46 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 28)); set => _innerValue = _innerValue & ~(0b11u << 28) | (((uint)value & 0b11) << 28); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO47 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 20)); set => _innerValue = _innerValue & ~(0b11u << 20) | (((uint)value & 0b11) << 20); }
}

public struct GPIO_PUP_PDN_CNTRL_REG3
{
    private uint _innerValue;
    public GPIO_PUP_PDN_CNTRLStatus GPIO48 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 0)); set => _innerValue = _innerValue & ~(0b11u << 0) | (((uint)value & 0b11) << 0); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO49 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 2)); set => _innerValue = _innerValue & ~(0b11u << 2) | (((uint)value & 0b11) << 2); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO50 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 4)); set => _innerValue = _innerValue & ~(0b11u << 4) | (((uint)value & 0b11) << 4); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO51 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 6)); set => _innerValue = _innerValue & ~(0b11u << 6) | (((uint)value & 0b11) << 6); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO52 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 8)); set => _innerValue = _innerValue & ~(0b11u << 8) | (((uint)value & 0b11) << 8); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO53 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 10)); set => _innerValue = _innerValue & ~(0b11u << 10) | (((uint)value & 0b11) << 10); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO54 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 12)); set => _innerValue = _innerValue & ~(0b11u << 12) | (((uint)value & 0b11) << 12); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO55 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 14)); set => _innerValue = _innerValue & ~(0b11u << 14) | (((uint)value & 0b11) << 14); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO56 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 16)); set => _innerValue = _innerValue & ~(0b11u << 16) | (((uint)value & 0b11) << 16); }
    public GPIO_PUP_PDN_CNTRLStatus GPIO57 { get => (GPIO_PUP_PDN_CNTRLStatus)(_innerValue & (0b11 << 18)); set => _innerValue = _innerValue & ~(0b11u << 18) | (((uint)value & 0b11) << 18); }
}
