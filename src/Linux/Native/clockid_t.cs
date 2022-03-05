namespace Linux.Native;

public enum clockid_t
{
    /// <summary> Identifier for system-wide realtime clock.</summary>
    CLOCK_REALTIME = 0,
    /// <summary> Monotonic system-wide clock.</summary>
    CLOCK_MONOTONIC = 1,
    /// <summary> High-resolution timer from the CPU.</summary>
    CLOCK_PROCESS_CPUTIME_ID = 2,
    /// <summary> Thread-specific CPU-time clock.</summary>
    CLOCK_THREAD_CPUTIME_ID = 3,
    /// <summary> Monotonic system-wide clock, not adjusted for frequency scaling.</summary>
    CLOCK_MONOTONIC_RAW = 4,
    /// <summary> Identifier for system-wide realtime clock, updated only on ticks.</summary>
    CLOCK_REALTIME_COARSE = 5,
    /// <summary> Monotonic system-wide clock, updated only on ticks.</summary>
    CLOCK_MONOTONIC_COARSE = 6,
    /// <summary> Monotonic system-wide clock that includes time spent in suspension.</summary>
    CLOCK_BOOTTIME = 7,
    /// <summary> Like CLOCK_REALTIME but also wakes suspended system.</summary>
    CLOCK_REALTIME_ALARM = 8,
    /// <summary> Like CLOCK_BOOTTIME but also wakes suspended system.</summary>
    CLOCK_BOOTTIME_ALARM = 9,
    /// <summary> Like CLOCK_REALTIME but in International Atomic Time.</summary>
    CLOCK_TAI = 11,

}