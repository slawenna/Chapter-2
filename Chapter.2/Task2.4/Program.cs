using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueInThen = 256;

            string valueToHex = Convert.ToString(valueInThen, 16);

            Console.WriteLine(valueToHex);

          
        }
    }
}
