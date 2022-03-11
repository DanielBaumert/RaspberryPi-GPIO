using Linux.Native;

using static Linux.Native.OpenFlags;
using static Linux.Native.MemoryProtection;
using static Linux.Native.MemoryMapMode;

using System;
using System.Diagnostics;
using System.Threading;

using Raspberry.Native;
using Raspberry.Native.Pi4;

namespace Raspberry;

public unsafe class GpioController : IDisposable
{
    private const uint PAGE_SIZE = (4 * 1024);
    private const uint BLOCK_SIZE = (4 * 1024);

    private EnvironmentBase _environment;

    private volatile uint* _gpioMap = null!;

    private uint* _gpioSetPtr = null!;
    private uint* _gpioClrPtr = null!;

    private static SpinLock s_spinlockSetMode = new SpinLock(Debugger.IsAttached);
    private static SpinLock s_spinlockSetOutput = new SpinLock(Debugger.IsAttached);
    public ref GpioRegister Register => ref *(GpioRegister*)_gpioMap;


    public GpioController(EnvironmentBase enviroment)
    {
        _environment = enviroment;

        int fpMem;
        if ((fpMem = LibC.open(enviroment.GPIO_MEM, O_RDWR | O_SYNC)) < 0)
        {
            Console.WriteLine(fpMem);
            throw new Exception($"can't open {enviroment.GPIO_MEM}");
        }

        _gpioMap = (uint*)LibC.mmap(
            null,
            BLOCK_SIZE,
            PROT_READ | PROT_WRITE,
            MAP_SHARED,
            fpMem,
            0);

        LibC.close(fpMem);

        _gpioSetPtr = _gpioMap + enviroment.SET_OFFSET;
        _gpioClrPtr = _gpioMap + enviroment.CLR_OFFSET;
    }

    public GpioOut GetGpioAsOutput(uint gpio)
    {
        return new GpioOut(_gpioMap, gpio, _environment);
    }

    public GpioIn GetGpioAsInput(uint gpio)
    {
        return new GpioIn(_gpioMap, gpio, _environment);
    }

    public void SetMode(uint gpio, FSELStatus direction)
    {
        Debug.Assert(gpio <= _environment.MAX_GPIO_COUNT, "gpio index out of range");
        Debug.Assert(direction is FSELStatus.Input or FSELStatus.Output, "direction supports only Input and Output");
        bool lockTaken = false;

        uint offset = _environment.CalcFSELRegisterOffset(gpio);
        uint shift = _environment.CalcFSELRegisterShift(gpio);

        try
        {
            s_spinlockSetMode.Enter(ref lockTaken);
            *(_gpioMap + offset) = (*(_gpioMap + offset) & ~(_environment.FSEL_REGISTER_METHODE_MASK << (int)shift)) | (((uint)direction) << (int)shift);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
        finally
        {
            if (lockTaken)
            {
                s_spinlockSetMode.Exit();
            }
        }
    }

    private bool disposedValue;
    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {

            }

            _ = LibC.munmap(_gpioMap, BLOCK_SIZE);

            disposedValue = true;
        }
    }

    ~GpioController()
    {
        Dispose(disposing: false);
    }

    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
