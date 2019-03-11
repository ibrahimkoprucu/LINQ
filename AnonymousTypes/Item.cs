namespace AnonymousTypes
{
  public class Item
  {
    public string Name { get; set; }
    public int ItemNumber { get; set; }

    public Item(string n, int inum)
    {
      Name = n;
      ItemNumber = inum;
    }
  }

  internal class InStockStatus
  {
    public int ItemNumber { get; set; }
    public string InStock { get; set; }

    public InStockStatus(int n, string b)
    {
      ItemNumber = n;
      InStock = b;
    }
  }
}