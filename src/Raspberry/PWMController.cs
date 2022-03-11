using Linux.Native;
using Timer = Linux.Timer;
using System;
using System.Threading;

namespace Raspberry;

public class PWMController { 

    private float _freq;
    private float _dutycycle;
    private float _basetime;
    private float _slicetime;
    private timespec _reqOn; 
    private timespec _reqOff;
    private GpioOut _gpio;
    private Thread _pwmThread;
    private CancellationTokenSource _pwmThreadCts;

    public float Freq { 
        get => _freq;
        set
        {
            if (value is <= 0.0f)
            {
                throw new NotSupportedException(nameof(Freq) + " must be > 0");
            }

            _freq = value;
            _basetime = 1000.0f / value;
            _slicetime = _basetime / 100.0f;
            CalculatePwmTimes();
        }
    }
    public float DutyCycle
    {
        get => _dutycycle;
        set
        {
            if (value is < 0.0f or > 100.0f)
            {
                throw new NotSupportedException(nameof(DutyCycle) + " must be 0.0 <= dutycycle <= 100.0");
            }

            _dutycycle = value;
            CalculatePwmTimes();
        }
    }

    internal PWMController(GpioOut gpio, float freq) { 
        if(freq is <= 0.0f) { 
            throw new NotSupportedException(nameof(freq) + " have to be > 0.0");
        }

        _gpio = gpio;
        _basetime = 1000.0f / freq;
        _slicetime = _basetime / 100.0f;
        CalculatePwmTimes();
    }

    public void Start() { 
        if(_pwmThread is null)
        {     
            _pwmThreadCts = new CancellationTokenSource();
            _pwmThread = new Thread(new ParameterizedThreadStart(PwmThread));
            _pwmThread.Start(_pwmThreadCts.Token);
        }   
    }

    public void Start(float dutycycle) { 
        DutyCycle = dutycycle;
        Start();
    }

    public void Stop() {
        if(_pwmThread is not null){ 
            _pwmThreadCts.Cancel();
            _pwmThread.Join();
        }
    } 

    private void CalculatePwmTimes() { 
        ulong usec;
        usec = (ulong)(_dutycycle * _slicetime * 1000.0);
        _reqOn.tv_sec = usec / 1000000UL;

        usec -= _reqOn.tv_sec * 1000000UL;
        _reqOn.tv_nsec = usec * 1000L;
        
            usec = (ulong)((100.0 - _dutycycle) * _slicetime * 1000.0);
        _reqOff.tv_sec = usec / 1000000UL;

        usec -= _reqOff.tv_sec * 1000000L;
        _reqOff.tv_nsec = usec * 1000L;
    }

    private void PwmThread(object obj) {

        CancellationToken ct = (CancellationToken) obj;

        while(!ct.IsCancellationRequested){ 
            if (_dutycycle > 0.0)
            {
                _gpio.High();
                Timer.Sleep(_reqOn);
            }

            if (_dutycycle < 100.0)
            {
                _gpio.Low();
                Timer.Sleep(_reqOff);
            }
        }

        _gpio.Low();
    }
}