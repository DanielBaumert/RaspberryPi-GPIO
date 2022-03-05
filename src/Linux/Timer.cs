using Linux.Native;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Linux;
public static class Timer
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void SleepUS(uint microsecond)
    {
        /// 1 microsecond = 10E-6
        /// 1 nanosecond = 10E-9
        /// 

        Unsafe.SkipInit(out timespec req);
        req.tv_sec = microsecond / 1000UL;
        req.tv_nsec = microsecond * 1000UL;

        Sleep(req);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void SleepNS(uint nanoseconds)
    {
        /// 1 nanosecond = 10E-9
        /// 
        Unsafe.SkipInit(out timespec req);
        req.tv_nsec = nanoseconds;

        Sleep(req);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Sleep(timespec req)
    {
        Unsafe.SkipInit(out timespec rem);
        if (LibC.nanosleep(ref req, ref rem) == -1)
        {
            Sleep(rem);
        }
    }

    public delegate void TimerInvoker();
    public static TimerInvoker CreateNopTimer(int cycleCount)
    {
        DynamicMethod delayN = new DynamicMethod(
            $"Delay{cycleCount}",
            null,
            null,
            typeof(Timer).Module);

        ILGenerator il = delayN.GetILGenerator();
        for (int i = 0; i < cycleCount; i++)
        {
            il.Emit(OpCodes.Nop);
        }
        il.Emit(OpCodes.Ret);

        return (TimerInvoker)delayN.CreateDelegate(typeof(TimerInvoker));
    }
}
