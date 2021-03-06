﻿using System;
using System.Collections.Generic;
using System.Text;
using OopPrincipals.Interfaces;

namespace OopPrincipals.Classes
{

    /// <summary>
    /// The is a concrete class that is derived from the land class and implements the IAttackPrey interface
    /// The methods return a string specific to the wolves class and you can see the diet is overridden to carnivore
    /// </summary>
    public class Wolves : Land, IAttackPrey
    {
        public override string Name { get; set; }
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
