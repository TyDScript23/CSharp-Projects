using System;
using LearnInterfaces;

namespace LearnInheritance
{

  //inherits from Vehicle class and implements ThisInterface
  //note how the base class comes before the interface, ALWAYS!!!
  class Sedan : Vehicle, ThisInterface
  {
    //this constructor will call the base constructor from Vehicle
    public Sedan(double speed):base(speed)
    {
      Wheels = 4;
    }

    //implementation of Honk method from ThisInterface
    public void Honk()
    {
      Console.WriteLine("Beep Beep!");
    }

    //here we override the ToString method from the base Object class
    public override string ToString()
    {
      return $"Sedan - Speed: {Speed}, Wheels: {Wheels}, License Plate: {LicensePlate}";
    }
  }
}