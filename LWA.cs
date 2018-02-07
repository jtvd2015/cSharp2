using System;
//using System.Text;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Length = 0;
            Console.Write("Enter Length: ");
            string stringLength = "";
            stringLength = Console.ReadLine();
            Length = decimal.Parse(stringLength);
            
            decimal Width = 0;
            Console.Write("Enter Width: ");
            string stringWidth = "";
            stringWidth = Console.ReadLine();
            Width = decimal.Parse(stringWidth);
            

            Console.WriteLine("The Area is: " + Length * Width);
            Console.ReadLine();
        }
    }
}
