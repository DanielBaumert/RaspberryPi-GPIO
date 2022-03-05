using System;

namespace Linux.Native;

[Flags]
public enum MemoryProtection : uint
{
    /// <summary> page can be read </summary>
    PROT_READ = 0x0000_0001,
    /// <summary> page can be written </summary>
    PROT_WRITE = 0x0000_0002,
    /// <summary> page can be executed </summary>
    PROT_EXEC = 0x0000_0004,
    /// <summary> page may be used for atomic ops </summary>
    PROT_SEM = 0x0000_0008,
    /// <summary> page can not be accessed </summary>
    PROT_NONE = 0x0000_0000
}
