using System;
using System.Linq;

namespace LINQ
{
  public class Program
  {
    private static void Main(string[] args)
    {
      string[] websites = { "hsNameA.com", "hsNameB.net", "hsNameC.net",
                           "hsNameD.com", "hsNameE.org", "hsNameF.org",
                          "hsNameG.tv",  "hsNameH.net", "hsNameI.com" };

      var webAddrs = from addr in websites
                     where addr.LastIndexOf('.') != -1//. var olanlardan
                     group addr by addr.Substring(addr.LastIndexOf('.'))//.com,.net,vs .ve sonrası
                     into ws                     //.net bir gruop .com ayrı diğerleri ayrı
                     where ws.Count() > 2         //.net den 2 den fazla var
                     select ws;                   //sadece .net leri seçti

      foreach (var item in webAddrs)
      {
        Console.WriteLine(item.Key + "burası");//.net

        foreach (var site in item)
        {
          Console.WriteLine(site);
        }
      }
    }
  }
}