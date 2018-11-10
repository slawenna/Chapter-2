using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = 5.25745243896m;
            decimal b = 9.8544531763m;
            a += b;
            Console.WriteLine(a.ToString("#.######"));
        }
    }
}
