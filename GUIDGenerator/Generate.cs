using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIDGenerator
{
  public class Generate
  {
    public static void Create(int amount)
    {
      int i = 0;

      if (amount == 1)
      {
        Console.WriteLine("Creating " + amount + " new GUID\n");
      }
      else
      {
        Console.WriteLine("Creating " + amount + " new GUID's\n");
      }
      
      while (i < amount)
      {
        Console.WriteLine(Guid.NewGuid());
        i++;
      }
      Environment.Exit(0);
    }
  }
}
