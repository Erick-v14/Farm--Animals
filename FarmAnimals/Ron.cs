using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmAnimals
{
    class Ron
    {
        public static void main()
        {
            Console.Clear();
            Console.WriteLine("-----Ron-----");
            Console.WriteLine("1. Talk to");
            Console.WriteLine("2. Feed");
            Console.WriteLine("3. Product info");
            var userselect1 = Console.ReadLine();
          //  bool quit = false;
            //do while loop for option selection
            //  do
            //  {

            if (userselect1 == "1")
            {
                Ron.speak();
            }
            else if (userselect1 == "2")
            {
                Ron.feed();
            }
            else if (userselect1 == "3")
            {
                Ron.product();
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
            Console.Write("Ron:");
            Console.Write("\"Howdy im Ron the farmer\"");
            Console.ReadKey();
            Console.Clear();
        }
        public static void feed()
        {
            Console.Clear();
            Console.WriteLine("You try to feed ron an orange");
            Console.Write("Ron:");
            Console.Write("\"Umm thanks for the orange but i dont want to eat it from your hand\"");
            Console.ReadKey();
            Console.Clear();
        }
        public static void product()
        {
            Console.Clear();
            Console.Write("Ron:");
            Console.Write("\"Im a farmer i provide delicious animal meat\"");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
