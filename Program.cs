////////// Run Some C# //////////

// Console.WriteLine() is a command that prints text to a console
// Like console.log() in js

using System;

namespace HelloWorld
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Hello Asta!");    
     }
  }
}

////////// Getting Input //////////

// Console.ReadLine() captures text that a user types into the console
// Run the terminal with dotnet run

using System;

namespace GettingInput
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Do you love to code?");
      string input = Console.ReadLine();
      Console.WriteLine($"{input}!");
    }
  }
}


 