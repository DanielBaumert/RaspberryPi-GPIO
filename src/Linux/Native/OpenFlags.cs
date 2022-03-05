using System;

namespace Linux.Native;

[Flags]
public enum OpenFlags : uint
{
    /// <summary> open for reading only </summary>
    O_RDONLY = 0x0000_0000,
    /// <summary> open for writing only </summary>
    O_WRONLY = 0x0000_0001,
    /// <summary> open for reading and writing </summary>
    O_RDWR = 0x0000_0002,
    /// <summary> mask for above modes </summary>
    O_ACCMODE = 0x0000_0003,
    /// <summary> set append mode </summary>
    O_APPEND = 0x0000_0008,
    /// <summary> create if nonexistant </summary>
    O_CREAT = 0x0000_0200,
    /// <summary> truncate to zero length </summary>
    O_TRUNC = 0x0000_0400,
    /// <summary> error if already exists </summary>
    O_EXCL = 0x0000_0800,
    /// <summary> signal pgrp when data ready </summary>
    O_ASYNC = 0x0000_0040,
    /// <summary>  </summary>
    O_SYNC = 0x0010_1000,
    /// <summary> set close_on_exec </summary>
    O_CLOEXEC = 0x0020_0000
}