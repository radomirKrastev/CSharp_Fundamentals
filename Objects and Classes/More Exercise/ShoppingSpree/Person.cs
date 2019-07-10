using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        public Person()
        {
            this.ProductsBag = new List<Product>();
        }

        public string Name { get; set; }
        public double Money { get; set; }
        public List<Product> ProductsBag {get; set;}
        
        public void AddProduct(Product product)
        {
            this.ProductsBag.Add(product);
        }

        public bool GetBuyResult(double money, double price)
        {
            var isPurchasePossible = false;
            if (money - price >= 0)
            {
                isPurchasePossible = true;
            }

            return isPurchasePossible;
        }

    }
}
