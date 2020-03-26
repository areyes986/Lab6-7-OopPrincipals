using System;
using System.Collections.Generic;
using System.Text;

namespace OopPrincipals.Classes
{
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
