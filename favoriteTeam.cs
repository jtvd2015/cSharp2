using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            //get input
            string input;
            
            do
            {
                      
            Console.WriteLine("Enter favorite baseball team: ");
            input = Console.ReadLine(); //this will make the user enter the requested data

            //test input

            if (input == "Reds" ||  
                input == "Cincinnati" ||
                input == "Cincinnati Reds")
            {
                //respond
                Console.WriteLine("You have chosen wisely.");
                    //break;  //this is the most likely choice, so the application can continue to run
                    //System.Environment.Exit(0);  //automatically closes the application
                    return;
            }

            else  
            {
                Console.WriteLine("Please try again.");
            }
            } while ( ! (input == "Reds" ||  
                         input == "Cincinnati" ||
                         input == "Cincinnati Reds")); //( ! (inputs)) says that if the answers entered are not correct

            //do it again

            Console.ReadLine(); //so the console window does not immediately close after entering the requested information

            //is the application finished? am i done?
        }
    }
}
