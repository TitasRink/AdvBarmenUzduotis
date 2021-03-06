using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvBarmenUzduotis.repo
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public string[] Drinks { get; set; }
        public string[] Food { get; set; }

        public Product(string[] food, string[] drinks)
        {
            Food = food;
            Drinks = drinks;
        }
        public virtual string[] ReturnValue()
        {

            var result = Food.Concat(Drinks);
            return (string[])result;
            
        }
    }
}
