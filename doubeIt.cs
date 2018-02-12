using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DoubleIt);
        }

        static int DoubleIt(int x)
        {
            return x * 2;
        }
    }
}