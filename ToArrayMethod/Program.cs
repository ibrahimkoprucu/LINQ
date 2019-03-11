using System;
using System.Linq;

namespace ToArrayMethod
{
  public class Program
  {
    private static void Main(string[] args)
    {
      int[] nums = { 1, -2, 3, 0, -4, 5 };

      var posNums = from n in nums
                    where n > 0
                    select n;
      int len = posNums.Count();
      Console.WriteLine(len);
    }
  }
}