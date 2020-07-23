using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Library
{
  class Program
  {
    static void Main(string[] args)
    {
      ConsoleKeyInfo keypress;
      bool flag = true;

      while (flag)
      {
        Console.Write("Enter number for converting:");
        var str = Console.ReadLine();
        str.ConvertInInt();
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
