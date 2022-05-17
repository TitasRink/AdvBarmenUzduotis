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

        public double OrderPrice { get; set; }
        public Order(DateTime dateNow, double orderPrice)
        {
            DateNow = dateNow;
            OrderPrice = orderPrice;
        }
    }
    public interface IOrderRepository
    {
        string checkClient();
        string checkRestoran();

        string checkSendEmail();
    }
}
