using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveADay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Okay " + name + ", How many fruits have you had to eat today?");
            int numberOfFruit = int.Parse(Console.ReadLine());

            if (numberOfFruit > 4)
            {
                Console.WriteLine("Good job, " + name + ". You've had your five a day!");
            }
            else
                Console.WriteLine("What are you doing " + name + "?!? Go and have your five a day!");
        }
    }
}
