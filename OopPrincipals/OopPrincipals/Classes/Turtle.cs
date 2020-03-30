using System;
using System.Collections.Generic;
using System.Text;
using OopPrincipals.Interfaces;

namespace OopPrincipals.Classes
{
    /// <summary>
    /// This is a concrete class that is derived from the reptile class and implements the IAttackPrey interface
    /// All the methods return a string specific to the turtle class
    /// The diet prop is overridden to be omnivore string
    /// </summary>
    public class Turtle : Reptiles, IAttackPrey
    {
        public override string Name { get; set; }
        public override string Diet { get; set; } = "Omnivore";
        public string SharpTeeth { get; set; } 

        public string ChasePrey()
        {
            return "I'm going as fast as i can! So close but yet so far..";
        }

        public override string Eat()
        {
            return $"I'm an {Diet},I like to eat strawberries and worms.";
        }

        public string LeapAtPrey()
        {
            return "TAKE THAT YOU BERRY.";
        }

        public override string Sound()
        {
            return "SNAP!";
        }

        public string StalkPrey()
        {
            return "This strawberry doesn't know what's comin... hehe.";
        }
    }
}
