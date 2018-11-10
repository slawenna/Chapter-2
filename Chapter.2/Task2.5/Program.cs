using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = '\u0072';

            Console.WriteLine(a);

            int valueInThen = 72;

            string valueToHex = Convert.ToString(valueInThen, 16);

            Console.WriteLine(valueToHex);
        }
    }
}