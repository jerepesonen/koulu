using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T36_Ostoskärry
{
    public class Product
    {
        public string Nimi { get; set; }
        public double Hinta { get; set; }

        public override string ToString()
        {
            return $"- product: {Nimi} {Hinta} e";
        }
        public static int Count(List<Product> products)
        {
            int e = 0;
            foreach (var item in products)
            {
                e++;
            }
            return e;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product() { Nimi = "Milk", Hinta = 1.4 };
            Product product2 = new Product() { Nimi = "Bread", Hinta = 2.2 };
            Product product3 = new Product() { Nimi = "Butter", Hinta = 3.2 };
            Product product4 = new Product() { Nimi = "Cheese", Hinta = 4.2 };
            List<Product> products = new List<Product> { product1, product2, product3, product4 };

            foreach (var item in products)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine($"There are {Product.Count(products)} products in the ostoskärry");
            Console.ReadLine();
        }
    }
}