using System;
using System.Collections.Generic;
using System.Text;

namespace OopPrincipals.Classes
{
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
