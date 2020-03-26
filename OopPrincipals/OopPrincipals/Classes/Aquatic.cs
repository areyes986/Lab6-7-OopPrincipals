using System;
using System.Collections.Generic;
using System.Text;

namespace OopPrincipals.Classes
{
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
