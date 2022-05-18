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
            var resultSplited = result.Split(';');
            return resultSplited;
        }
    }
}
