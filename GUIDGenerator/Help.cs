using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIDGenerator
{
  public class Help
  {
    public static void GUIDConvert()
    {
      //2 arguements first = convert too second = guid
      Console.WriteLine("GUID Conversion!\n");
      Console.WriteLine("  This takes 2 additional arguments...");
      Console.WriteLine("  CMD Line is as follows: convert net c40ee1a5-143e-40cf-9f54-f4a9acb0d6f8\n");
      Console.WriteLine("  CMD Options are:");
      Console.WriteLine("    1, convert to: net or oracle");
      Console.WriteLine("    2, GUID to convert: This can be with or without the - throughout the number.\n");
      Environment.Exit(0);
    }

    public static void Generate()
    {
      //1 arguement = amount of new guids to create
      Console.WriteLine("GUID Generator!\n");
      Console.WriteLine("  This takes 1 additional argument...");
      Console.WriteLine("  CMD Line is as follows: create 5\n");
      Console.WriteLine("  CMD Options are:");
      Console.WriteLine("    1, Number of GUID's to create\n");
      Environment.Exit(0);
    }

    public static void Validate()
    {
      //1 argument = guid to validate
      Console.WriteLine("GUID Validator!\n");
      Console.WriteLine("  This takes 1 additional argument...");
      Console.WriteLine("  CMD Line is as follows: verify c40ee1a5-143e-40cf-9f54-f4a9acb0d6f8\n");
      Console.WriteLine("  CMD Options are:");
      Console.WriteLine("    1, GUID to verify\n");
      Environment.Exit(0);
    }

    public static void All()
    {
      Console.WriteLine("GUID Generator\n");
      Console.WriteLine("  This tool takes 3 main arguments, they are as follows:");
      Console.WriteLine("  1, Convert");
      Console.WriteLine("  2, Create");
      Console.WriteLine("  3, Verify");
      Console.WriteLine("  Each of these take additional arguments which are listed below...\n");

      Console.WriteLine("GUID Conversion!\n");
      Console.WriteLine("  This takes 2 additional arguments...");
      Console.WriteLine("  CMD Line is as follows: convert net c40ee1a5-143e-40cf-9f54-f4a9acb0d6f8\n");
      Console.WriteLine("  CMD Options are:");
      Console.WriteLine("    1, convert to: net or oracle");
      Console.WriteLine("    2, GUID to convert: This can be with or without the - throughout the number.");

      Console.WriteLine("GUID Generator!\n");
      Console.WriteLine("  This takes 1 additional argument...");
      Console.WriteLine("  CMD Line is as follows: create 5\n");
      Console.WriteLine("  CMD Options are:");
      Console.WriteLine("    1, Number of GUID's to create\n");

      Console.WriteLine("GUID Validator!\n");
      Console.WriteLine("  This takes 1 additional argument...");
      Console.WriteLine("  CMD Line is as follows: verify c40ee1a5-143e-40cf-9f54-f4a9acb0d6f8\n");
      Console.WriteLine("  CMD Options are:");
      Console.WriteLine("    1, GUID to verify\n");
      Environment.Exit(0);
    }
  }
}
