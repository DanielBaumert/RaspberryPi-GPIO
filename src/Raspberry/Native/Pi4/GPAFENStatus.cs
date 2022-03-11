namespace Raspberry.Native.Pi4;

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
