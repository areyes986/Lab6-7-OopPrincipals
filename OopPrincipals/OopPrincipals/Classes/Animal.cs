using System;
using System.Collections.Generic;
using System.Text;

namespace OopPrincipals.Classes
{
     public abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract string Diet { get; set; }
        public abstract string Blood { get; set; }
        public abstract string Birth { get; set; }
        public virtual bool HasLegs { get; set; } = true;

        public abstract string Sound();
        public abstract string Eat();
        public virtual bool CanRun()
        {
            return true;
        }

    }
}
