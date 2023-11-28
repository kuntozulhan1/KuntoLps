namespace KuntoLps.Controllers
{
    public class Task4
    {
        class Program
        {
            static void Main(string[] args)
            {
                var myList = new List<Product>();
                while (true)
                {
                    // populate list with 1000 integers  
                    for (int i = 0; i < 1000; i++)
                    {
                        myList.Add(new Product(Guid.NewGuid().ToString(), i));
                    }
                    // do something with the list object  
                    Console.WriteLine(myList.Count);

                    /// <summary>
                    /// clear the list, Keeping references to objects unnecessarily
                    /// </summary>
                    myList.Clear();
                }
            }
        }
        class Product
        {
            public Product(string sku, decimal price)
            {
                SKU = sku;
                Price = price;
            }
            public string SKU { get; set; }
            public decimal Price { get; set; }
        }
    }
}
