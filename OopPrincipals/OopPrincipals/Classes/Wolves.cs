using System;
using System.Collections.Generic;
using System.Text;
using OopPrincipals.Interfaces;

namespace OopPrincipals.Classes
{
    public class Wolves : Land, IAttackPrey
    {
        public override string Diet { get; set; } = "Carnivore";
        public string SharpTeeth { get; set; } = "I have razor sharp teeth!";
        public bool Hungry { get; set; }

        public string ChasePrey()
        {
            return $"Since {LivesInPack}, we all will chase this bunny together! RUN GUYS RUN!";
   
        }

        public string LeapAtPrey()
        {
            return "Pounce!";
        }

        public override string Sound()
        {
            return "ROOOOOOOAAAAAAARRRR!!!!";
        }

        public string StalkPrey()
        {
            if (Hungry)
            {
                return "I silently watch my prey with by buddies..";
            }
            else
            {
                return "That bunny was YUUUMMY!";
            }
        }
    }
}
