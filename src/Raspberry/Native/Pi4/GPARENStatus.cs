namespace Raspberry.Native.Pi4;

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
