namespace Raspberry.Native.Pi4;

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
