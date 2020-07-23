using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_ExceptionHandling
{
  class Program
  {
    static void Main(string[] args)
    {
      ConsoleKeyInfo keypress;
      bool flag = true;

      while (flag)
      {
        try
        {
          Console.Write("Enter string: ");
          string str = Console.ReadLine();

          if (str == "")
          {
            throw new StringIsEmptyException("String must be filled.");
          }
          else
          {
            Console.WriteLine("First letter: " + StringSplitter.TakeFirstLetter(str));
          }
        }
        catch (Exception e)
        {
          Console.WriteLine($"Error: {e.Message}");
        }

        Console.WriteLine("Press Ctrl+X for exit. Press Enter for continue:");
        keypress = Console.ReadKey();

        if ((ConsoleModifiers.Control & keypress.Modifiers) != 0)
        {
          if (keypress.Key == ConsoleKey.X)
          {
            flag = false;
          }
        }
      }
    }
  }
}
