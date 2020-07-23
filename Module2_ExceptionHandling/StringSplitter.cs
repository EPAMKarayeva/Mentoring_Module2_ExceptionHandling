using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_ExceptionHandling
{
 public static class StringSplitter
  {
    public static char TakeFirstLetter(string str)
    {
      var letter = str.First();
      return letter;
    }
  }
}
