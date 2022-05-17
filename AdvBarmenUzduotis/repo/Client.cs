using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvBarmenUzduotis.repo
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Client(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
