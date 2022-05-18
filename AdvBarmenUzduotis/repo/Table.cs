using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvBarmenUzduotis.repo
{
    public class Table 
    {
        public List<Table> Tables { get; set; }
        public int Number { get; set; }
        public bool TableReserved { get; set; }
        public int TableSeats { get; set; }
        public Table(int number, bool tableReserved, int tableSeats)
        {
            Number = number;
            TableReserved = tableReserved;
            TableSeats = tableSeats;
        }
    }
}
