using System;

namespace LearnInheritance
{
  class Vehicle
  {
    public string LicensePlate
    { get; private set; }

    public double Speed
    { get; private set; }

    public int Wheels
    { get; protected set; }

    public Vehicle(double speed) {
      Speed = speed;

      //this line is commented out to avoid dependency on Tools class
      //LicensePlate = Tools.GenerateLicensePlate();
    }

    public void SpeedUp()
    {
      Speed += 5;
    }

    public void SlowDown()
    {
      Speed -= 5;
    }
    
    public void Honk()
    {
      Console.WriteLine("HONK!");
    }

  }
}