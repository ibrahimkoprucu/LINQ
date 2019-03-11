using System;
using System.Linq;

namespace CreateAGroupJoin
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      string[] travelTypes = {
          "Air",
          "Sea",
          "Land"
     };

      Transport[] transports = {
          new Transport("Bicycle", "Land"),
          new Transport("Balloon", "Air"),
          new Transport("Boat", "Sea"),
          new Transport("Jet", "Air"),
          new Transport("Canoe", "Sea"),
          new Transport("Biplane", "Air"),
          new Transport("Car", "Land"),
          new Transport("Cargo Ship", "Sea"),
          new Transport("Train", "Land")
     };

      var byHow = from how in travelTypes
                  join trans in transports
                  on how equals trans.How
                  into lst
                  select new { How = how, Tlist = lst };

      foreach (var item in byHow)
      {
        Console.WriteLine("----------------");
        Console.WriteLine("transport türü={0}", item.How);

        foreach (var type in item.Tlist)
        {
          Console.WriteLine("kullanılan araç={0}", type.Name);
        }
      }
    }
  }
}