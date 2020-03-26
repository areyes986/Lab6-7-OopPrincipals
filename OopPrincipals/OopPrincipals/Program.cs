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

                if (aniSwimming is Hippo && aniSwimming is Dolphins)
                {
                    var h = (Hippo)aniSwimming;
                    var d = (Dolphins)aniSwimming;
                    h.WiggleBody();
                    d.WiggleBody();
                    h.Float();
                    d.Float();
                }

                //ICanSwim(swim[i]);
            }


            //static void ICanSwim(ISwim canSwim)
            //{
            //    Console.WriteLine($"We can hold our breath canSwim.HoldBreathAmount));
            //}
        }
    }
}
