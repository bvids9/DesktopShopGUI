using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemClassLibrary
{
    public class Store
    {
        public List<Product> ItemList { get; set; }
        public List<Product> ShoppingList { get; set; }

        public Store()
        {
            ItemList = new List<Product>();
            ShoppingList = new List<Product>();
        }

        public decimal Checkout()
        {
            // initialise total cost
            decimal totalCost = 0;
            foreach (var c in ShoppingList)
            {
                totalCost = totalCost + c.Price;
            }
            // Empty the list
            ShoppingList.Clear();
            return totalCost;
        }
    }
}
