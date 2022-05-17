using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvBarmenUzduotis.repo
{
    public class Food : Order
    {
        public string Meat { get; set; }
        public Food(string meat, DateTime dateNow, double orderPrice) : base(dateNow, orderPrice)
        {
            Meat = meat;
        }
    }
}
