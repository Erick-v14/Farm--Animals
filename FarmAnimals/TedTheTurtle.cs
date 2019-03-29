using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmAnimals
{
    class TedTheTurtle
    {
        public static void main()
        {
            Console.Clear();
            Console.WriteLine("-----Ted The Turtle-----");
            Console.WriteLine("1. Talk to");
            Console.WriteLine("2. Feed");
            Console.WriteLine("3. Product info");
            var userselect1 = Console.ReadLine();
            bool quit = false;
            //do while loop for option selection
            //  do
            //  {

            if (userselect1 == "1")
            {
                TedTheTurtle.speak();
            }
            else if (userselect1 == "2")
            {
                TedTheTurtle.feed();
            }
            else if (userselect1 == "3")
            {
                TedTheTurtle.product();
            }
            else
            {
                Console.WriteLine("Sorry I dont understand your selection");
                Console.WriteLine("Try again");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void speak()
        {
            Console.Clear();
            Console.Write("Ted The Turtle: ");
            Console.Write("\".....\"");
            Console.ReadKey();
            Console.Clear();
        }
        public static void product()
        {
            Console.Clear();
            Console.Write("Ted the Turtle: ");
            Console.Write("\" .....!\"");
            Console.ReadKey();
            Console.Clear();
        }
        public static void feed()
        {
            Console.Clear();
            Console.Write("You feed Ted the Turtle a stick of celery");
            Console.Write("\".....\"");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
