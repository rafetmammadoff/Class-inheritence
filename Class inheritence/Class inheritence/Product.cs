using System;
using System.Collections.Generic;
using System.Text;

namespace Class_inheritence
{
    internal class Product
    {
        public Product(int price)
        {
            Price = price;
        }
        public string Brand;
        public string Name;
        public int Price;

        public void ShowInfo()
        {
            Console.WriteLine($"{Name} {Price}");
        }
    }
}
