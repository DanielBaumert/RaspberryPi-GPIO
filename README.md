# RaspberryPi-GPIO
GPIO controller lib for the bcm2711 (Raspberry PI 4)


# Example

## Ultrasonic Sensor HC-SR04
```cs
const uint TR_GPIO = 11;
const uint EC_GPIO = 8;

Stopwatch stopwatch = new Stopwatch();
using GpioController gpio = new GpioController();
GpioOut tr = gpio.GetGpioAsOutput(TR_GPIO);
GpioIn ec = gpio.GetGpioAsInput(EC_GPIO);

tr.High();
Timer.SleepUS(10);
tr.Low();

while (!ec.GetValueBool());
stopwatch.StartUnsafe(); 
// or 
while (ec.GetValueUint() == 1);
stopwatch.StopUnsafe();

timespec d = stopwatch.GetDelta();
var distance = (d.tv_nsec * 340 / 2) / 1_000_000;

Console.Write($"{distance, 12} mm");
```

# Install Dotnet on Pi
https://github.com/DanielBaumert/Dev-Scripts/wiki/Dotnet-On-Pi
