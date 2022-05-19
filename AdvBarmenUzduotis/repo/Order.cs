using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvBarmenUzduotis.repo
{
    public class Order
    {
        public List<Order> Orders { get; set; }
        public DateTime DateNow { get; set; }
        Product Product { get; set; }
        public Order(DateTime dateNow, Product product)
        {   
            Product = product;
            DateNow = dateNow;
            Product = product;
            product.ReturnValue();
        }
    }
}
