using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmAnimals
{
    class HarryTheHorse
    {
        public static void main()
        {
            Console.Clear();
            Console.WriteLine("-----Harry the Horse-----");
            Console.WriteLine("1. Talk to");
            Console.WriteLine("2. Feed");
            Console.WriteLine("3. Product info");
            var userselect1 = Console.ReadLine();

            if (userselect1 == "1")
            {
                HarryTheHorse.speak();
            }
            else if (userselect1 == "2")
            {
                HarryTheHorse.feed();
            }
            else if (userselect1 == "3")
            {
                HarryTheHorse.product();
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
            Console.Write("Harry the Horse: ");
            Console.Write("\" neighhhhhhhhhh!\"");
            Console.ReadKey();
            Console.Clear();
        }
          public static void feed()
        {

            Console.Clear();
            Console.WriteLine("You feed harry a sugar cube");
            Console.Write("Harry the Horse:");
            Console.Write("\"Thanks friend, that was delicious\"");
            Console.ReadKey();
            Console.Clear();
        }
        public static void product()
        {
            Console.Clear();
            Console.WriteLine("Harry the Horse:");
            Console.WriteLine("\"Im a horse, people ride me and race me around tracks!\"");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
