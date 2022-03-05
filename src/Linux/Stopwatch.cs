using System;
using System.Runtime.CompilerServices;

namespace Linux.Native;
public class Stopwatch
{
    private timespec _t1;
    private timespec _t2;

    private clockid_t _ck_id;
    public Stopwatch(clockid_t clockid = clockid_t.CLOCK_REALTIME)
    {
        _ck_id = clockid;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Start()
    {
        if(LibC.clock_gettime(_ck_id, ref _t1) is < 0)
        {
            throw new Exception("Error in stopwatch");
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void StartUnsafe()
    {
        _ = LibC.clock_gettime(_ck_id, ref _t1);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Stop()
    {
        if (LibC.clock_gettime(_ck_id, ref _t2) is < 0)
        {
            throw new Exception("Error in stopwatch");
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void StopUnsafe()
    {
        _ = LibC.clock_gettime(_ck_id, ref _t2);
    }

    public timespec GetDelta()
    {
        return new timespec
        {
            tv_sec = _t2.tv_sec - _t1.tv_sec,
            tv_nsec = _t2.tv_nsec - _t1.tv_nsec
        };
    }
    

}
