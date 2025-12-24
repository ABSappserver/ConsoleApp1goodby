using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1goodby
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number > 0)
            {
                Console.WriteLine("Goodbye!");
                Console.ReadLine();
            }
            else if (number < 0)
            {
                Console.WriteLine("No Goodbye!");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("No Response");
                Console.ReadLine();
            }

        }
    }
}