using Linux.Native;

using static Linux.Native.OpenFlags;
using static Linux.Native.MemoryProtection;
using static Linux.Native.MemoryMapMode;

using System;
using System.Diagnostics;
using System.Threading;

using Raspberry.Pi4.Native;

namespace Raspberry.Pi4;

public unsafe class GpioController : IDisposable { 
    private const uint PAGE_SIZE = (4*1024);
    private const uint BLOCK_SIZE = (4*1024);
    private volatile uint* _gpioMap = null!;

    private static SpinLock s_spinlockSetMode = new SpinLock(Debugger.IsAttached);
    private static SpinLock s_spinlockSetOutput = new SpinLock(Debugger.IsAttached);
    public ref GpioRegister Register =>  ref *(GpioRegister*) _gpioMap;

    /// <summary>
    /// Offset of the GPIO set register
    /// </summary>
    public const uint SET_OFFSET = 7;

    /// <summary>
    /// Offset of the GPIO clear register
    /// </summary>
    public const uint CLR_OFFSET = 10;

    public GpioController() { 
        int fpMem;
        if((fpMem = LibC.open(Enviroment.GPIO.GPIO_MEM, O_RDWR | O_SYNC)) < 0){ 
            Console.WriteLine(fpMem);
            throw new Exception($"can't open {Enviroment.GPIO.GPIO_MEM}");
        }

        _gpioMap = (uint*) LibC.mmap(
            null,
            BLOCK_SIZE,
            PROT_READ | PROT_WRITE,
            MAP_SHARED,
            fpMem,
            0);

        LibC.close(fpMem);
    }

    public GpioOut GetGpioAsOutput(uint gpio) { 
        return new GpioOut(_gpioMap, gpio);
    }

    public GpioIn GetGpioAsInput(uint gpio) { 
        return new GpioIn(_gpioMap, gpio);
    }
    
    public void SetMode(uint gpio, FSELStatus direction)
    {
        Debug.Assert(gpio <= 57, "gpio index out of range");
        Debug.Assert(direction is FSELStatus.Input or FSELStatus.Output, "direction supports only Input and Output");
        bool lockTaken = false;

        uint offset = gpio / 10;
        uint shift = (gpio % 10) * 3;
        
        try{
            s_spinlockSetMode.Enter(ref lockTaken);
            *(_gpioMap + offset) = (*(_gpioMap + offset) & ~(0b111u << (int) shift)) | (((uint) direction) << (int) shift);
        } catch(Exception e) {
            Console.WriteLine(e.ToString());
        } finally { 
            if(lockTaken){
                s_spinlockSetMode.Exit();
            }
        }
    }

    /// <summary>
    /// True: high (1)<br/>
    /// False: low (0)
    /// </summary>
    public void SetOutput(uint gpio, bool value)
    {
        Debug.Assert(gpio <= 57, "gpio index out of range");
        
        #if DEBUG
            Console.WriteLine($"{gpio}: {value}");
        #endif

        bool lockTaken = false;
        try{ 
            s_spinlockSetOutput.Enter(ref lockTaken);
            *(_gpioMap + (value ? SET_OFFSET : CLR_OFFSET) + (gpio >> 5)) = (1u << (int)(gpio & 0b11111));
        } catch(Exception e){
            Console.WriteLine(e.ToString());
        } finally { 
            if(lockTaken){
                s_spinlockSetOutput.Exit();
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
