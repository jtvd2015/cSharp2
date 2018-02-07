using System;
//using System.Text;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your job title?");
            string jobTitle = Console.ReadLine();
            jobTitle = jobTitle.ToLower();


            
            switch (jobTitle)
            {
                case "manager":
                    Console.WriteLine("You receive 4 weeks of vacation.");
                    break;
                case "sales rep":
                    Console.WriteLine("You receive 3 weeks of vacation.");
                    break;
                case "intern":
                    Console.WriteLine("Unfortunatley, you will not receive any vacation.");
                    break;
                default:
                    Console.WriteLine("Do you even work here?");
                    break;
            }

            Console.ReadLine();

        }
    }
}
