using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmAnimals
{
    class PinkyThePig
    {
        public static void main()
        {
            // main menu 3 options when you select pinky
            Console.Clear();
            Console.WriteLine("-----Pinky the Pig-----");
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
                    PinkyThePig.speak();
                }
                else if (userselect1 == "2")
                {
                    PinkyThePig.feed();
                }
                else if (userselect1 == "3")
                {
                    PinkyThePig.product();
                }              
                    else
                {
                    Console.WriteLine("Sorry I dont understand your selection");
                    Console.WriteLine("Try again");
                    Console.ReadKey();
                    Console.Clear();
                }
         //   } while (!quit);

        }
        //do while loop inside pinkythepig main was breaking everything??
        // still investigating 


        //class that brings up text when you feed pinky
        static void feed()
        {
            Console.Clear();
            Console.WriteLine("You feed pinky the pig a rotten apple");
            Console.Write("Pinky The Pig:");
            Console.Write("\"Thanks friend, that apple was delicious\"");
            Console.ReadKey();
            Console.Clear();
         

        }
        
        //class that brings up text when you speak to pinky
        static void speak()
        {
            Console.Clear();
            Console.WriteLine(" Pinky the Pig:");
            Console.WriteLine("\"Hey there buddy my name is pinky the pig...");
            Console.WriteLine(".... I mean Oink Oink\"");
            Console.ReadKey();
            Console.Clear();
        }
        
        //class that brings up text when you select product
        static void product()
        {
            Console.Clear();
            Console.WriteLine("Pinky the Pig:");
            Console.WriteLine("\"Im a pig so supply delicious bacon to the hungry children of the world\"");
            Console.ReadKey();
            Console.Clear();
       
           
        }
    }
}
