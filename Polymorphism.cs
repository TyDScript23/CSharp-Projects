using System;

namespace PolymorphismBasics
{
  public class Employee
  {
    //virtual method that can be overridden in derived classes
    public virtual void MakeHRRequest()
    {
      Console.WriteLine("Employee makes an HR request.");
    }
  }

  //abstract class example
  //methods in abstract classes must be overridden in derived classes
  public abstract class Employee2 {
    public abstract void MakeHRRequest();
    public void Promotion () {
      Console.WriteLine("You did it!");
    }
  }

  public class Intern : Employee2 {
    public override void MakeHRRequest() {
      Console.WriteLine("Intern makes an HR request.");
    }
  }

  public class Manager : Employee
  {
    //override the base class method
    public override void MakeHRRequest()
    {
      Console.WriteLine("Manager makes an HR request.");
    }
  }

  public class Engineer : Employee
  {
    //override the base class method
    public override void MakeHRRequest()
    {
      Console.WriteLine("Engineer makes an HR request.");
    }
  }

  public class Polymorphism
  {
    public static void Main(string[] args)
    {
      Manager manager1 = new Manager();
      manager1.MakeHRRequest();

      //notice how employee calls its own method even though it's referenced as an Employee
      Engineer engineer1 = new Engineer();
      engineer1.MakeHRRequest();

      //We can also upcast base classes to derived classes
      Employee myEmployeeManager = manager1;

      //now the Employee overriden method is used here
      myEmployeeManager.MakeHRRequest();

      //you can also downcast employee back to manager
      Manager manager2 = (Manager)myEmployeeManager;
      manager2.MakeHRRequest();

      //you can also print a statement to check one object can be casted to another type
      Console.WriteLine("Is manager1 an Employee? " + (manager1 is Employee));

      //you can also downcast using the 'as' keyword
      Employee myEmployeeEngineer = engineer1 as Employee;
      myEmployeeEngineer.MakeHRRequest();

      //abstract class example
      Intern intern1 = new Intern();
      intern1.MakeHRRequest();

      //notice how we can call the Promotion method from the abstract base class
      intern1.Promotion();
    }
  }
}