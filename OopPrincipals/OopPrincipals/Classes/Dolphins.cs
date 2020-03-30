using System;
using System.Collections.Generic;
using System.Text;
using OopPrincipals.Interfaces;

namespace OopPrincipals.Classes
{
    /// <summary>
    /// The Dolphin class is derived from the Aquatic class and implements the interface ISwim
    /// In this concrete class has more specific details on the dolphins traits and what it can do.
    /// </summary>
    public class Dolphins : Aquatic, ISwim

    {
        public override string Name { get; set; }
        public override bool HasLegs { get; set; } = false;
        public override string Diet { get; set; } = "Carnivore";
        public override int HoldBreathAmount { get; set; } = 10;

        public override string Hunt()
        {
            return "I used my sonar skills with my buddies to look for fishies to eat!";
        }
        public override string Eat()
        {
            return "I have a little mouth to eat little fish with.";
        }

        public override bool CanRun()
        {
            return false;
        }

        public string WiggleBody()
        {
            return $"I wiggle my entire body to go through water and can hold my breath for {HoldBreathAmount} minutes!";
        }

        public string Float()
        {
            return "Floating is my middle name";
        }
    }
}
