using System;

namespace Linux.Native;

[Flags]
public enum MemoryMapMode : uint
{
    /// <summary> Share changes </summary>
    MAP_SHARED = 0x0000_0001,
    /// <summary> Changes are private </summary>
    MAP_PRIVATE = 0x0000_0002,
    /// <summary> share + validate extension flags </summary>
    MAP_SHARED_VALIDATE = 0x0000_0003,
    /// <summary> Mask for type of mapping </summary>
    MAP_TYPE = 0x0000_000f,
    /// <summary> Interpret addr exactly </summary>
    MAP_FIXED = 0x0000_0010,
    /// <summary> don't use a file </summary>
    MAP_ANONYMOUS = 0x0000_0020,
    /// <summary> stack-like segment </summary>
    MAP_GROWSDOWN = 0x0000_0100,
    /// <summary> ETXTBSY </summary>
    MAP_DENYWRITE = 0x0000_0800,
    /// <summary> mark it as an executable </summary>
    MAP_EXECUTABLE = 0x0000_1000,
    /// <summary> pages are locked </summary>
    MAP_LOCKED = 0x0000_2000,
    /// <summary> don't check for reservations </summary>
    MAP_NORESERVE = 0x0000_4000,
    /// <summary> populate (prefault) pagetables </summary>
    MAP_POPULATE = 0x0000_8000,
    /// <summary> do not block on IO </summary>
    MAP_NONBLOCK = 0x0001_0000,
    /// <summary> give out an address that is best suited for process/thread stacks </summary>
    MAP_STACK = 0x0002_0000,
    /// <summary> create a huge page mapping </summary>
    MAP_HUGETLB = 0x0004_0000,
    /// <summary> perform synchronous page faults for the mapping </summary>
    MAP_SYNC = 0x0008_0000,
    /// <summary> MAP_FIXED which doesn't unmap underlying mapping </summary>
    MAP_FIXED_NOREPLACE = 0x0010_0000,
    /// <summary> For anonymous mmap, memory could </summary>
    MAP_UNINITIALIZED = 0x0400_0000,
}