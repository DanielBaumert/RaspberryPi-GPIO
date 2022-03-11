namespace Raspberry.Native.Pi4;

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
