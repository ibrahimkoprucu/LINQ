using System;
using System.Linq;

namespace LinqQueryMethods
{
  public class Program
  {
    private static void Main(string[] args)
    {
      int[] nums = { 1, -2, 3, 0, -4, 5 };
      var posNums = nums.Where(n => n > 0).Select(r => r);
      foreach (int i in posNums)
      {
        Console.Write(i + " ");
      }

      Console.WriteLine("eee");
    }
  }
}