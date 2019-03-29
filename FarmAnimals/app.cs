using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmAnimals
{
    class app

    {
        public static void main()
        {
            app.intro();
        }
        public static void intro()
        {
            bool quit = false;
           do
            {
                Console.WriteLine("******Welcome to the Farm******");
                Console.WriteLine("1. Harry the Horse");
                Console.WriteLine("2. Ted the Turtle");
                Console.WriteLine("3. Pinky the pig");
                Console.WriteLine("4. Daffy the duck");
                Console.WriteLine("5. Ron the farmer");
                var userselection = Console.ReadLine();
                if (userselection == "1")
                {
                    HarryTheHorse.main();
                }
                else if (userselection == "2")
                {
                    TedTheTurtle.main();
                }
                else if (userselection == "3")
                {
                    PinkyThePig.main();
                }
                else if (userselection == "4")
                {
                    DaffyTheDuck.main();
                }
                else if (userselection == "5")
                {
                    Ron.main();
                }
                else
                {
                    Console.WriteLine("Sorry I dont understand your selection");
                    Console.WriteLine("Try again");
                    Console.ReadKey();
                    Console.Clear();
                }
            }while (!quit);
        }
    }
}
