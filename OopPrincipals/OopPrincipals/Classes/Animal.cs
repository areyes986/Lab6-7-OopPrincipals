using System;
using System.Collections.Generic;
using System.Text;

namespace OopPrincipals.Classes
{
    /// <summary>
    /// This is the base/abstract class Animal, the abstract properties are to be overridden by other derived classes
    /// The HasLegs property and CanRun method is set to true for all derived classes unless overridden
    /// </summary>
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
