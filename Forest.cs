using System;


//these are some examples of classes that can be references in main
namespace StaticFields
{
  public class Forest
  {
    // FIELDS/PROPERTIES

    //property for name with an implicit getter and setter
    public string Name
    { get; set; }

    //property for number of trees with an implicit getter and setter
    public int Trees
    { get; set; }

    private int age;

    //property for age with a custom getter and setter
    //age cannot be negative
    //setter is private so age can only be changed within the class
    public int Age
    { 
      get { return age; }
      private set {
        if (value < 0) 
        {
          age = 0;
        } 
        else 
        {
          age = value; 
        }
      }
    }

    private string biome;

    //property for biome with a custom getter and setter
    //setter only allows specific biome types
    public string Biome
    {
      get { return biome; }
      set
      {
        string[] validBiomes = {"Tropical", "Temperate", "Boreal"};
        if (Array.IndexOf(validBiomes, value) >= 0) 
        {
          biome = value;
        }
        else 
        {
          biome = "Unknown";
        }
      }
    }

    public static int ForestsCreated
    {
      get; private set;
    }

    private static string forestFacts;
    private static string ForestFacts
    { 
      get 
      {
        return forestFacts;
      } 
    }

    // CONSTRUCTORS
    public Forest(string name, string biome)
    {
      Name = name;
      Biome = biome;
      Age = 0;
      ForestsCreated++;
    }
    
    //overloaded constructor that only requires a name, sets biome to "Unknown"
    public Forest(string name) : this(name, "Unknown")
    { }
    
    //here is an example of a static constructor
    static Forest() {
      forestFacts = "Forests provide a diversity of ecosystem services including:\n\taiding in regulating climate.\n\tpurifying water.\n\tmitigating natural hazards such as floods.\n";
      
      ForestsCreated = 0;
    }
    
    
    // METHODS
    public int Grow()
    {
      Trees += 30;
      Age += 1;
      return Trees;
    }
    
    public int Burn()
    {
      Trees -= 20;
      Age += 1;
      return Trees;
    }
    
  }
}
