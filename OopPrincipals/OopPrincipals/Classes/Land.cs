using System;
using System.Collections.Generic;
using System.Text;

namespace OopPrincipals.Classes
{
    /// <summary>
    /// This is a base/abstract class that is also derived from the Mammals class
    /// All animals that are derived from this land class will return strings for the following methods and properties
    /// </summary>
    public abstract class Land : Mammals
    {
        public override string Habitat { get; set; } = "lives on land";

        public override string Hunt()
        {
            return "I hunt for animals smaller than me!";
        }

        public override string CanHoldBreath()
        {
            return "I can only hold my breath for a little while :(";
        }

        public override string Eat()
        {
            return "I use my sharp canines to rip the flesh off of my tasty meals!";
        }
    }
}
