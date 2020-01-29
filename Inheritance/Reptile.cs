using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            Eyes = 2;
        }
        public bool HasScales = true;
        public bool CanSwim { get; set; }
        public bool HasTail { get; set; }
        public bool IsVenomous { get; set; }
    }
}
