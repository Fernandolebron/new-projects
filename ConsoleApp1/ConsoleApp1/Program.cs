using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("How many Hoirs of sleep did you get last night? ");
            int hours = int.Parse(Console.ReadLine());

            if (hours >= 8)
            {
                Console.WriteLine("Hello, " + name + " | " + "Sleep Hours: " + hours + "You are well rested");

            }
            else {
                Console.WriteLine("Hello, " + name + " | " + "Sleep Hours: " + hours + " | "+ "You need more sleep hours");
            }
        }
    }
}
