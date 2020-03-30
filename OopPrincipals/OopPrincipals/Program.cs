using OopPrincipals.Classes;
using OopPrincipals.Interfaces;
using System;

namespace OopPrincipals
{
    class Program
    {

        /// <summary>
        /// The main will call all of the methods created
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO ALLY'S ZOO! Here is a preview of some of our animals, they want to introduce themselves!");
            Console.ReadLine();
            WeCanSwim();
            Console.WriteLine("=======================================================");
            ReptilesCanMakeSoundsAndEat();
            Console.WriteLine("=======================================================");
            PoorSnakeHasNoLegsAndCantRun();
            Console.ReadLine();
            Console.WriteLine("That's it for now! BYE BYE! VISIT US AGAIN!");

        }
        /// <summary>
        /// This method shows an example of interface methods being implemented
        /// </summary>
        public static void WeCanSwim()
        {
            ISwim[] swim = new ISwim[2];

            // Creating new Hippo Objects
            Hippo hiphop = new Hippo() { Name = "Hippy the Hippo", HoldBreathAmount = 5 };
            Dolphins dolphins = new Dolphins() { Name = "Fin", HoldBreathAmount = 10 };

            swim[0] = hiphop;
            swim[1] = dolphins;

            // for loop that will loop through the swim array and will call the interface methods that are 
            //implemented in the classes
            for (int i = 0; i < swim.Length; i++)
            {
                var aniSwimming = swim[i];

                if (aniSwimming is Hippo)
                {
                    var h = (Hippo)aniSwimming;
                    Console.WriteLine($"My name is {h.Name} and I can hold my breath for {h.HoldBreathAmount} minutes!");
                    Console.WriteLine(h.WiggleBody());
                    Console.WriteLine(h.Float());
                    Console.ReadLine();
                }
                else if (aniSwimming is Dolphins)
                {
                    var d = (Dolphins)aniSwimming;
                    Console.WriteLine();
                    Console.WriteLine($"Hi! My name is {d.Name}!");
                    Console.WriteLine(d.WiggleBody());
                    Console.WriteLine(d.Float());
                    Console.ReadLine();

                }
            }
        }

        /// <summary>
        /// This method shows inheritance 
        /// </summary>
        public static void ReptilesCanMakeSoundsAndEat()
        {
            Turtle turti = new Turtle() { Name = "Turtie" };
            Console.WriteLine($"Hi! My name is {turti.Name} and I make {turti.Sound()} noises!");
            Console.WriteLine(turti.Eat());
            Console.WriteLine();
            Console.ReadLine();


            Snake snek = new Snake() { Name = "Snek" };
            Console.WriteLine($"Hi! My name is {snek.Name} and I make {snek.Sound()} noises!");
            Console.WriteLine(snek.Eat());
            Console.ReadLine();

        }

        /// <summary>
        /// This method displays polymorphism. 
        /// This virtual property and method were originally set to true but I overrode it to be false.
        /// </summary>
        public static void PoorSnakeHasNoLegsAndCantRun()
        {
            Snake snek = new Snake() { Name = "Snek" };

            Console.WriteLine($"Hey guys, still me, {snek.Name}");
            Console.Write("TRUE OR FALSE! I HAVE LEGS AND CAN WALK: ");
            string userInput = Console.ReadLine().ToLower();

            // just a very simple if else statement if the user enters the correct answer or not.
            if (userInput == "true")
            {
                Console.WriteLine($"You are wrong, me having legs is {snek.HasLegs} and me running is definitely {snek.CanRun()}");
                Console.WriteLine("Yet that is what makes me so cool!");
            }
            else if (userInput == "false")
            {
                Console.WriteLine($"You're correct! Me having legs is {snek.HasLegs} and me running is definitely {snek.CanRun()}");
                Console.WriteLine("Yet that is what makes me so cool!");
            }
            else
            {
                Console.WriteLine($"That's not a valid answer but me having legs is {snek.HasLegs} and me running is definitely {snek.CanRun()}");
                Console.WriteLine("Yet that is what makes me so cool!");

            }
        }
    }
}
