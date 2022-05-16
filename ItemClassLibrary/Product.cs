using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemClassLibrary
{
    public class Product
    {
        public string Item { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        // Default constructor
        public Product()
        {
            Item = "nothing yet";
            Category = "nothing yet";
            Price = 0.00M;
        }

        // Paramatised constructor
        public Product(string a, string b, decimal c)
        {
            Item = a;
            Category = b;
            Price = c;
        }

        override public string ToString()
        {
            return $"Item: {Item} Category: {Category} Price: ${Price}";
        }

        public string displayItem()
        {
            return $"{Item} - ${Price}";
        }


    }
}
