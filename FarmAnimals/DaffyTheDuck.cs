using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmAnimals
{
    class DaffyTheDuck
    {
        public static void main()
        {
            Console.Clear();
            Console.WriteLine("-----Daffy the Duck-----");
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
                DaffyTheDuck.speak();
            }
            else if (userselect1 == "2")
            {
                DaffyTheDuck.feed();
            }
            else if (userselect1 == "3")
            {
                DaffyTheDuck.product();
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
            Console.Write("Daffy the Duck: ");
            Console.Write("\" Quack Quack!\"");
            Console.ReadKey();
            Console.Clear();
        }
        public static void product()
        {
            Console.Clear();
            Console.WriteLine("Im Daffy the Duck:\" I fly around so people can shoot at me!\"");
            Console.ReadKey();
            Console.Clear();
        }
        public static void feed()
        {
            Console.Clear();
            Console.WriteLine("You feed Daffy The Duck a Carrot");
            Console.Write("Daffy The Duck:");
            Console.Write("\"How do you expect me to eat this? I have no teeth!\"");
            Console.ReadKey();
            Console.Clear();

        }

    }
}
