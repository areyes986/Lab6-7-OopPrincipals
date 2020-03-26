using System;
using System.Collections.Generic;
using System.Text;

namespace OopPrincipals.Interfaces
{
    interface IAttackPrey
    {
        public string SharpTeeth { get; set; }

        string StalkPrey();
        string ChasePrey();
        string LeapAtPrey();




    }
}
