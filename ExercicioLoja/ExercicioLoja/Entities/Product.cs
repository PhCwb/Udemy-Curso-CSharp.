using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLoja.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(){}
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag() //Compra normal
        {
            return $"{Name} {Price.ToString("C")}";
        }

    }
}
