// int - whole numbers, like: 1, -56, 948
// double - decimal numbers, like: 239.43909, -660.01
// char - single characters, like: “a”, “&”, “£”
// string - string of characters, like: “dog”, “hello world”
// bool - boolean values, like: true or false


////////// ASSIGNING VARIABLES //////////

// Declare an integer
int myAge;
myAge = 33;

// Declare a string
string myName = "Asta"

using System;

namespace Form
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create Variables
      string name = "Shadow";
      string breed = "Golden Retriever";
      int age = 5;
      double weight = 65.22;
      bool spayed = true;

      // Print variables to the console
      Console.WriteLine(name);
      Console.WriteLine(breed);
      Console.WriteLine(age);
      Console.WriteLine(weight);
      Console.WriteLine(spayed);
    }
  }
}
