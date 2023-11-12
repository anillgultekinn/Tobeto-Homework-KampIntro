using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class BasketManager
    {
        // naming convention
        // syntax
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : {0}", product.Name);
        }

        public void Add2(string productName, string productDescription, double unitPrice, int productInStock)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : {0}", productName);
        }


    }
}
