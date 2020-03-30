using System;
using System.Collections.Generic;
using System.Text;

namespace OopPrincipals.Interfaces
{
    /// <summary>
    /// This is an interface of the traits needed for a class to attack the prey
    /// all classes that implement this interface needs to use all props and methods within this interface
    /// </summary>
    interface IAttackPrey
    {
        public string SharpTeeth { get; set; }

        string StalkPrey();
        string ChasePrey();
        string LeapAtPrey();




    }
}
