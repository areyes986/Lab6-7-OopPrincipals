using System;
using System.Collections.Generic;
using System.Text;

namespace OopPrincipals.Classes
{
    /// <summary>
    /// This is a base/abstract class that is derived from the animal class
    /// Some properties are overridden for all animals of the reptile class to be coldblooded and lay eggs
    /// the HasScales prop and CanSnapAtYou method is set to true unless overridden
    /// </summary>
    public abstract class Reptiles : Animal
    {
        public override sealed string Blood { get; set; } = "Cold-blooded";
        public override string Birth { get; set; } = "eggs";
        public virtual bool HasScales { get; set; } = true;

       public virtual bool CanSnapAtYou()
        {
            return true;
        }
    }
}
