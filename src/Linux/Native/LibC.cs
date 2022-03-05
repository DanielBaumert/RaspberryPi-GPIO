using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Linux.Native;

public unsafe static class LibC
{
    [DllImport("libc")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static extern void* mmap(
        void* addr,
        nuint length,
        MemoryProtection prot,
        MemoryMapMode flags,
        int fd,
        uint offset);

    [DllImport("libc")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static extern int munmap(
        void* addr, 
        nuint length);

    [DllImport("libc", CharSet = CharSet.Ansi)]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static extern int open(
        string pathName, 
        OpenFlags flags);

    [DllImport("libc")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static extern nuint close(int fd);

    [DllImport("libc")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static extern int nanosleep(
        ref timespec req, 
        ref timespec rem);

    [DllImport("libc")]
    public static extern int clock_gettime(
        clockid_t clk_id, 
        ref timespec tp);
}
