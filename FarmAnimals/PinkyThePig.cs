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
            Console.WriteLine("1. Talk to");
            Console.WriteLine("2. Feed");
            Console.WriteLine("3. Product info");
            var userselect = Console.ReadLine();
            bool quit = false;
            //do while loop for option selection
            do
            {
                
                    if (userselect == "1")
                {
                    PinkyThePig.speak();
                }
                else if (userselect == "2")
                {
                    PinkyThePig.feed();
                }
                else if (userselect == "3")
                {
                    PinkyThePig.product();
                }
            } while (!quit);

        }
        //class that brings up text when you feed pinky
        static void feed()
        {
            Console.WriteLine("You feed pinky the pig a rotten apple");
            Console.WriteLine("Pinky The Pig:");
            Console.Write("\"Thanks friend, that apple was delicious\"");
           
        }
        
        //class that brings up text when you speak to pinky
        static void speak()
        {
            Console.WriteLine(" Pinky the Pig:");
            Console.WriteLine("\"Hey there buddy my name is pinky the pig\"");
            Console.WriteLine("\".... I mean Oink Oink\"");
 
        }
        
        //class that brings up text when you select product
        static void product()
        {
            Console.WriteLine("Pinky the Pig:");
            Console.WriteLine("\"Im a pig so supply delicious bacon to the hungry children of the worl\"");
        
        }
    }
}
