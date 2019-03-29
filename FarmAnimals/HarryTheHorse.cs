using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmAnimals
{
    class HarryTheHorse
    {
        public static void speak()
        {
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\"Hey! Its your boy Harry the Horse\"");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
