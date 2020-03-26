using System;
using System.Collections.Generic;
using System.Text;

namespace OopPrincipals.Interfaces
{
    interface ISwim
    {
        public int HoldBreathAmount { get; set; }

        string WiggleBody();

        string Float();

    }
}
