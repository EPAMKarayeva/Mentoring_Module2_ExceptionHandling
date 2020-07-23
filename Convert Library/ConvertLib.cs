using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Library
{
  public static class ConvertLib
  {
    public static void ConvertInInt(this string text)
    {
        int result;

        try
        {
          result = Convert.ToInt32(text);
          Console.WriteLine("Converted the {0} value '{1}' to the {2} value {3}.", text.GetType().Name, text, result.GetType().Name, result);
        }
        catch (OverflowException)
        {
          Console.WriteLine("{0} is outside the range of the Int32 type.", text);
        }
        catch (FormatException)
        {
          Console.WriteLine("The {0} value '{1}' is not in a recognizable format.", text.GetType().Name, text);
        }
    }
  }
}
