using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio136.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quant { get; set; }

        public Product(string name, double price, int quant)
        {
            Name = name;
            Price = price;
            Quant = quant;
        }

        public double Total()
        {
            return Price * Quant;
        }


    }
}
