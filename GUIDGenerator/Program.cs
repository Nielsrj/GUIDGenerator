using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIDGenerator
{
  class Program
  {
    static void Main(string[] args)
    {
      if (args.Count() == 0 || args[0] == "?" || args[0] == "/?" || args[0] == "help")
      {
        Help.All();
      }

      if (args[0].ToLower() == "convert")
      {
        if (args.Count() == 3)
        {
          string convertTo = args[1];
          string GUID = args[2];

          Guid validate;
          bool result = Guid.TryParse(GUID, out validate);

          if (result)
          {
            Console.WriteLine("GUID: " + GUID + " is a valid GUID");
            GUIDConvert.PerformConversion(convertTo, GUID);
          }
          else
          {
            Console.WriteLine("GUID: " + GUID + " is NOT a valid GUID");
            Environment.Exit(1);
          }
        }
        else
        {
          Console.WriteLine("Incorrect number of arguments...\n");
          Help.GUIDConvert();
        }
      }
      else if (args[0].ToLower() == "create")
      {
        if (args.Count() == 2)
        {
          int num;
          bool test = int.TryParse(args[1], out num);
          if (test)
          {
            Generate.Create(num);
          }
          else
          {
            Console.WriteLine("Non-Numeric value used on command line...\n");
            Help.Generate();
          }
        }
        else
        {
          Console.WriteLine("incorrect Number of arguments...\n");
          Help.Generate();
        }
      }
      else if (args[0].ToLower() == "verify")
      {
        if (args.Count() == 2)
        {
          string GUID = args[1];
          Validate.check(GUID);
        }
        else
        {
          Console.WriteLine("incorrect Number of arguments...\n");
          Help.Validate();
        }
      }
      else
      {
        Console.WriteLine("Unrecognised Argument: " + args[0]);
        Help.All();
      }
    }
  }
}
