using System;

namespace LearnInheritance
{

  //inherits from Vehicle class
  class Truck : Vehicle
  { 
    public double Weight
    { get; }

    //this constructor will call the base constructor from Vehicle
    public Truck(double speed, double weight):base(speed)
    {
      Weight = weight;

      if (weight < 400)
      {
        Wheels = 8;
      }
      else
      {
        Wheels = 12;
      }
    }

    //here we override the ToString method from the base Object class
    public override string ToString()
    {
      return $"Truck - Speed: {Speed}, Wheels: {Wheels}, License Plate: {LicensePlate}, Weight: {Weight}";
    }

  }
}