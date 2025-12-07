using System;

//define an interface
//all methods and properties of an interface are declared but not implemented
namespace LearnInterfaces
{
  interface ThisInterface {
    public string LicensePlate{
      get;
    }
    public double Speed{
      get;
    }
    public int Wheels{
      get;
    }

    //notice that this is only the method's signature, not its implementation
    public void Honk();
  }
}