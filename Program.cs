using System;
using System.Numerics;

namespace HelloWorld
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Tyler Davis");

      // Ask user for fave number
      Console.Write("Enter your favorite number!: ");

      // Turn that answer into an int    

      String faveNumber = Console.ReadLine();

      int newInt = Convert.ToInt32(faveNumber);

      Console.Write("The number that you wrote was " + newInt + "\n");

      //Now let's understand the difference between a double and a decimal

      //just a standard double
      double standardDouble = 39.76876;

      decimal decimalNotDouble = 489872.76m;

      float standardFloat = 489872.76f;

      // both of these are valid double declarations
      double doubleDeclareOne = 39.766;
      double doubleDeclareTwo = 42.686d;

      Console.Write(standardDouble + " " + decimalNotDouble + " " + standardFloat + " " + doubleDeclareOne + " " + doubleDeclareTwo);

      //now we will play around with some built in functions

      // Starting variables 
      int numberOne = 12932;
      int numberTwo = -2828472;

      // Use built-in methods and save to variable 
      double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));

      // Use built-in methods and save to variable 

      double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));
      // Print the lowest number

      Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt));


      //Now let's mess around with some strings

      // First string variable
      string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune must be in want of a wife.";
      // Second string variable
      string firstSpeech = "\"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\"";

      // Print variable and newline
      Console.WriteLine(firstSentence);
      Console.WriteLine();
      Console.WriteLine(firstSpeech);

      //here is some strintg interpolation

      
      // Declare the variables
      string beginning = "Once upon a time,";
      string middle = "The kid climbed a tree";
      string end = "Everyone lived happily ever after.";

      // Interpolate the string and the variables
      
      string story = $"{beginning} {middle} {end}";

      // Print the story to the console 
      Console.WriteLine(story);

      //a few more string attributes...
      
      // Create password
      string password = "a92301j2add";

      // Get password length
      
      int passwordLength = password.Length;

      // Check if password uses symbol

      int passwordCheck = password.IndexOf("!");
      // Print results
      Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");


      //Now let's grab a substring and pull a character
      // dna strand
      string startStrand = "ATGCGATGAGCTTAC";

      // find location of "tga"
      int tga = startStrand.IndexOf("TGA");
      Console.WriteLine(tga);

      // start point and stop point variables
      int startPoint = 0;
      int length = tga + 3;

      // define final strand
      string dna = startStrand.Substring(startPoint,length);
      Console.WriteLine(dna);

      // DNA mutation search
      Console.WriteLine(dna[3]);

      //Let's practice on changing between uppercase and lower case

      // Script line
      string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";

      // Get camera directions
      int charPosition = script.IndexOf("Close");
      int secondLength = "Close on".Length;
      string cameraDirections = script.Substring(charPosition, secondLength);

      // Get scene description
      charPosition = script.IndexOf("a portrait");
      string sceneDescription = script.Substring(charPosition);

      // Make camera directions uppercase

      cameraDirections = cameraDirections.ToUpper();

      // Make scene description lowercase
      sceneDescription = sceneDescription.ToLower(); 

      // Print results
      Console.WriteLine(cameraDirections);
      Console.WriteLine(sceneDescription);


      //Let's try some boolean values
      int cookiesSoldGuess = 250;
      int storeOneCookies = 110;
      int storeTwoCookies = 135;
      
      int cookiesSoldActual = storeOneCookies + storeTwoCookies;

      bool guessedCorrect = cookiesSoldGuess == cookiesSoldActual;

      Console.WriteLine(guessedCorrect);

      //let's do another boolean operator
        double timeToDinner = 4;
        double distance = 95;
        double rate = 30;

        double tripDuration = distance/rate;

        bool answer = tripDuration <= timeToDinner;

        Console.WriteLine(answer);

        //now some logical operators
        bool beach = true;
        bool hiking = false;
        bool city = true;

        bool yourNeeds = beach && city;
        bool friendNeeds = beach || hiking;

        bool tripDecision = yourNeeds && friendNeeds;
        Console.WriteLine(tripDecision);


        //Now let's try some if-else statements
        int people = 11;
        string weather = "nice";

        if(people <= 10 && weather == "nice"){
          Console.WriteLine("SaladMart");
        } 
        else {
        Console.WriteLine("Soup N Sandwich");
        }

        double ph = 7.0;
        
        if(ph < 7.0) {
          Console.WriteLine("Acidic");
        }
        else if(ph > 7.0) {
          Console.WriteLine("Basic");
        }
        else {
          Console.WriteLine("Neutral");
        }

        //let's do a similar thing but with a switch statement

        double ph2 = 14;

        switch(ph2) 
        {
          case <= 3: 
            Console.WriteLine("Very Acidic");
            break;
          case >= 11:
            Console.WriteLine("Very Basic");
            break;
          case < 7:
            Console.WriteLine("Acidic");
            break;
          case > 7:
            Console.WriteLine("Basic");
            break;
          default: 
            Console.WriteLine("Neutral");
            break;
        }

        //let's practice with ternary statements
        int pepperLength = 4;

        string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";

        Console.WriteLine(message);


        //Here is an example of an out paramter
        string scoreAsString = "85.6";
        string statement = "Hello World";
        
        double scoreAsDouble;
        bool outcome = Double.TryParse(scoreAsString, out scoreAsDouble);

        Console.WriteLine(outcome);
        Console.WriteLine(scoreAsDouble);
     }
  }
}