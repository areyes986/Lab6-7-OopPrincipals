using System;
using System.Collections.Generic;
using System.Text;

namespace OopPrincipals.Classes
{
    /// <summary>
    /// This is a base/abstract class for Aquatic animals and is derived from the Mammals class.
    /// all animals derived from the aquatic class will like to be in water
    /// all animals derived from the aquatic class all have a hold breath amount
    /// all animals derived from the aquatic class will return a string for the methods 
    /// </summary>
    public abstract class Aquatic : Mammals
    {
        public override string Habitat { get; set; } = "likes to be in water";

        public abstract int HoldBreathAmount { get; set; }

        public override string CanHoldBreath()
        {
            return "I can hold my breath for what seems like forever!";
        }

        public override string Sound()
        {
            return "I make a GLUB GLUB GLUB sound in the water.";
        }

    }
}
