using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIDGenerator
{
  public class Validate
  {
    public static void check(string GUIDValue)
    {
      Guid validate;
      bool result = Guid.TryParse(GUIDValue, out validate);

      if (result)
      {
        Console.WriteLine("GUID: " + GUIDValue + " is a valid GUID");
        Environment.Exit(0);
      }
      else
      {
        Console.WriteLine("GUID: " + GUIDValue + " is NOT a valid GUID");
        Environment.Exit(0);
      }
    }
  }
}
