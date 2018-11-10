using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello"; 
            string b = "World"; 
            object d = (a +" "+ b);  
            string c = (string)d; 
            Console.WriteLine(c);
        }
    }
}
