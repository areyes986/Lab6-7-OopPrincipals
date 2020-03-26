using OopPrincipals.Classes;
using OopPrincipals.Interfaces;
using System;

namespace OopPrincipals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ISwim[] swim = new ISwim[2];

            Hippo hiphop = new Hippo() { HoldBreathAmount = 10 };
            Dolphins dolphins = new Dolphins() { HoldBreathAmount = 10 };
 
            swim[0] = hiphop;
            swim[1] = dolphins;

            for (int i = 0; i < swim.Length; i++)
            {
                var aniSwimming = swim[i];

                if (aniSwimming is Hippo)
                {
                    var h = (Hippo)aniSwimming;
                    Console.WriteLine(h.WiggleBody());
                    Console.WriteLine(h.Float());
                    Console.WriteLine($"I can hold my breath for {h.HoldBreathAmount} minutes!");
                    Console.WriteLine("=======================================================================");
                }
                else if (aniSwimming is Dolphins)
                {
                    var d = (Dolphins)aniSwimming;
                    Console.WriteLine(d.WiggleBody());
                    Console.WriteLine(d.Float());
                    Console.WriteLine($"I can hold my breath for {d.HoldBreathAmount} minutes!");
                }
            }
        }
    }
}
