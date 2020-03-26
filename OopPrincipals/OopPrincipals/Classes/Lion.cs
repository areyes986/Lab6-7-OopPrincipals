using System;
using System.Collections.Generic;
using System.Text;
using OopPrincipals.Interfaces;

namespace OopPrincipals.Classes
{
    public class Lion : Land
    {
        public override string Diet { get; set; } = "Carnivore";

        public override string Sound()
        {
            return "ROOOOOOOAAAAAAARRRR!!!!";
        }
    }
}
