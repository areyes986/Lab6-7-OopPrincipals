using System;
using System.Collections.Generic;
using System.Text;
using OopPrincipals.Interfaces;

namespace OopPrincipals.Classes
{
    /// <summary>
    /// This is a concrete class that is derived from the reptiles class
    /// and implements the ISwim interface. All of the methods return specific strings that are specific to the snake class
    /// You can see the HasLegs prop was overridden to false as well overriding diet to carnivore and breathAmount to its specific int
    /// </summary>
    public class Snake : Reptiles, ISwim
    {
        public override string Name { get; set; }
        public override string Diet { get; set; } = "Carnivore";

        public override bool HasLegs { get; set; } = false;
        public int HoldBreathAmount { get; set; } = 10;
        public override string Eat()
        {
            return "I like to shove whatever I can into my itty bitty mouth";
        }

        public override string Sound()
        {
            return "HISSSSSssssSSSSssss";
        }

        public override bool CanRun()
        {
            return false;
        }

        public string WiggleBody()
        {
            return "Though I have no limps, I am full capable swimming! Wiggling this body is life.";
        }

        public string Float()
        {
            WiggleBody();
            return "As long as I wiggle, I will float.";
           
        }

    }
}
