namespace Raspberry.Native.Pi4;

public enum GPIO_PUP_PDN_CNTRLStatus
{
    NoResistorIsSelected = 0b00,
    PullUpResistorIsSelected = 0b01,
    PullDownResistorIsSelected = 0b10,
    Reserved = 0b11,
}
