using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvBarmenUzduotis.repo
{
    internal class Drink : Order

    {
        public string CocaCola { get; set; }
        public Drink(string cocaCola, DateTime dateNow, double orderPrice) : base(dateNow, orderPrice)
        {
            CocaCola = cocaCola;
        }
    }
}
