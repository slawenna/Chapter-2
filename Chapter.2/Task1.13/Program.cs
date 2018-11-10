using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            int b = 10;

            int a2 = b;

            b = a;

            a = a2;

            Console.WriteLine($"{а} {b}");
        }
    }
}
