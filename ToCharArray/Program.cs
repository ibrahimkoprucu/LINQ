using System.Linq;

namespace ToCharArray
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      string[] strs = { "alpha", "beta", "gamma" };

      var chrs = from str in strs
                 let chrArray = str.ToCharArray()
                 from ch in chrArray
                 orderby ch descending
                 select ch;
      foreach (var item in chrs)
      {
        System.Console.WriteLine(item);
      }
    }
  }
}