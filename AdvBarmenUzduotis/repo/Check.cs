using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvBarmenUzduotis.repo
{
    internal class Check
    {
        public int Id { get; set; }
        public int Table { get; set; }
        public DateTime Date { get; set; }
        public Product Product { get; set; }
        public double Sum { get; set; }


        public Check(int id, int table, Product product, DateTime date)
        {
            Id = id;
            Table = table;
            Product = product;
            Date = date;
        }
        public void PrintCheck(int id, int tablenumber, DateTime date)
        {
            var res = Check (id, tablenumber, date, null);
            string path = $"C:\temp\check.txt";
            File.WriteAllLines(path, Check);
        }
    }
}
