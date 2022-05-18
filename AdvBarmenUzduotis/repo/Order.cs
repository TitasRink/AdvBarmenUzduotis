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

        

     

        public Order(DateTime dateNow)
        {
            
            DateNow = dateNow;
           
        }
    }
    public interface IOrderRepository
    {
        string checkClient();
        string checkRestoran();

        string checkSendEmail();
    }
}
