using System;
using System.Collections.Generic;
using System.Text;
using OopPrincipals.Interfaces;

namespace OopPrincipals.Classes
{
    /// <summary>
    /// This is a concrete class derived from the land class. The diet is overridden to a specific string
    /// and the sound method returns a string as well
    /// </summary>
    public class Lion : Land
    {
        public override string Name { get; set; }
        public override string Diet { get; set; } = "Carnivore";

        public override string Sound()
        {
            return "ROOOOOOOAAAAAAARRRR!!!!";
        }
    }
}
