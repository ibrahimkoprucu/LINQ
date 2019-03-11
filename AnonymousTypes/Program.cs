using System.Linq;

namespace AnonymousTypes
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Item[] items = {
         new Item("Pliers", 1424),
         new Item("Hammer", 7892),
         new Item("Wrench", 8534),
         new Item("Saw", 6411)
    };
      InStockStatus[] statusList = {
         new InStockStatus(1424, "var"),
         new InStockStatus(7892, "yok"),
         new InStockStatus(8534, "var"),
         new InStockStatus(6411, "yok")
     };

      var inStockList = from item in items
                        join entry in statusList
                        on item.ItemNumber equals entry.ItemNumber
                        select new
                        {
                          urun = item.Name,
                          stoktaMi = entry.InStock
                        };

      foreach (var item in inStockList)
      {
        System.Console.WriteLine(item.urun);
        System.Console.WriteLine(item.stoktaMi);
      }
    }
  }
}