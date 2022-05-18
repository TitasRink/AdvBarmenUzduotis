using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvBarmenUzduotis.repo
{
    public class Drink : Product
        
    {
        public override string[] ReturnValue()
        {
            string result = File.ReadAllText(@"C:\temp\Drinks.txt");
            var resultSplited = result.Split(';');
            return resultSplited;
        }
    }
}
