using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvBarmenUzduotis.repo
{
    public class Barmen: Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Barmen(int id, string name): base(id, name)
        {
            Id = id;
            Name = name;
        }
    }
    
}
