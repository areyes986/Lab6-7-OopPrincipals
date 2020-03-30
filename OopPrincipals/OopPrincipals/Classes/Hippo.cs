using System;
using System.Collections.Generic;
using System.Text;
using OopPrincipals.Interfaces;


namespace OopPrincipals.Classes
{
    /// <summary>
    /// This is a concrete class that is derived from the Aquatic class 
    /// and also implements the IAttackPrey and ISwim interfaces
    /// The hippo has specific strings it returns when the methods are used. 
    /// We also see that the diet is overridden to herbivore and the breathamount overrides to a specific int
    /// </summary>
    public class Hippo : Aquatic, IAttackPrey, ISwim
    {
        public override string Name { get; set; }
        public override string Diet { get; set; } = "Herbivore";
        public bool FeelingAggressive { get; set; }
        public string SharpTeeth { get; set; } 
        public override int HoldBreathAmount { get; set; } = 5;

        public override string Hunt()
        {
            return "I'm a ferocious herbivore, but I do not hunt.";
        }
        public override string Eat()
        {
            return "I eat with my big mouth!";
        }

        public string StalkPrey()
        {
            return "The only stalking I do I eating stalks of celery";
        }

        public string ChasePrey()
        {
            if (FeelingAggressive)
            {
                return "I WILL DESTROY YOU!";
            }
            else
                return "I'm just chillin.";
        }

        public string LeapAtPrey()
        {
            return "My weight will literally end you.";
        }

        public string WiggleBody()
        {
            return "I can wiggle my short little legs and I will swim.";
        }

        public string Float()
        {
            return "Yes, it may not seem like I can.. but I do float.";
        }
    }
}
