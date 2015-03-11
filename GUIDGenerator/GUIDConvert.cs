using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIDGenerator
{
  public class GUIDConvert
  {
    public static void PerformConversion(string convertTo, string GUID)
    {
      if (convertTo.ToLower() == "oracle")
      {
        Console.WriteLine("Converting GUID from Dot NET to Oracle...");
        Console.WriteLine("New GUID: " + DotNetToOracle(GUID));
      }
      else if (convertTo.ToLower() == "net")
      {
        Console.WriteLine("Converting GUID from Oracle to Dot NET...");
        Console.WriteLine("New GUID: " + OracleToDotNet(GUID));
      }
      else
      {
        Console.WriteLine("Unrecognised argument...");
        Help.GUIDConvert();
      }
    }

    static string OracleToDotNet(string text)
    {

      byte[] bytes = ParseHex(text);
      Guid guid = new Guid(bytes);
      return guid.ToString();
    }

    static string DotNetToOracle(string text)
    {
      Guid guid = new Guid(text);
      return BitConverter.ToString(guid.ToByteArray()).Replace("-", "");
    }

    static byte[] ParseHex(string text)
    {
      // Not the most efficient code in the world, but
      // it works...
      byte[] ret = new byte[text.Length / 2];
      for (int i = 0; i < ret.Length; i++)
      {
        ret[i] = Convert.ToByte(text.Substring(i * 2, 2), 16);
      }
      return ret;
    }
  }
}
