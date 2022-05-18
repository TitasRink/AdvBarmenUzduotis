using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvBarmenUzduotis.repo
{
    public class Food : Product
    {

        public override string[]  ReturnValue()
        {
            string result = File.ReadAllText(@"C:\temp\Food.txt");
            Name = result.Split(';')[0];
            Price = Convert.ToDouble(result.Split(':')[1]);
            return Foods;

        }

    }
}
