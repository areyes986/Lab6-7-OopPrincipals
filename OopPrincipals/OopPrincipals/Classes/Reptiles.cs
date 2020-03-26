using System;
using System.Collections.Generic;
using System.Text;

namespace OopPrincipals.Classes
{
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
