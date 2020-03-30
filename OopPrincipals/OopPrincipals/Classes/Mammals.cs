using System;
using System.Collections.Generic;
using System.Text;

namespace OopPrincipals.Classes
{
    /// <summary>
    /// This is a base/abstract class that is derived from the animal class
    /// All animals from the Mammals class is overridden to be warm blooded, have live births and live with buddies
    /// </summary>
    public abstract class Mammals : Animal
    {
        public override sealed string Blood { get; set; } = "warm blooded";
        public override sealed string Birth { get; set; } = "live birth";
        public abstract string Habitat { get; set; }

        public virtual string LivesInPack { get; set; } = "I live with my buddies";

        public abstract string Hunt();

        public abstract string CanHoldBreath();




    }
}
