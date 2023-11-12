namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            Product product = new Product();
            product.Name = "Elma";
            product.UnitPrice = 15;
            product.Description = "Amasya elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.UnitPrice = 80;
            product2.Description = "Diyarbakır karpuzu";

            Product[] products = new Product[] {
         product,product2
     };

            foreach (var item in products)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.UnitPrice);
                Console.WriteLine(item.Description);
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine("-----------------Methods------------------");

            //instance
            //encapsulation


            BasketManager basketManager = new BasketManager();
            basketManager.Add(product);
            basketManager.Add(product2);

            basketManager.Add2("Armut", "Yeşil armut", 12, 10);
            basketManager.Add2("Elma", "Yeşil elma", 12, 9);
            basketManager.Add2("Karpuz", "Diyarbakır karpuzu", 12, 8);
        }
    }
}