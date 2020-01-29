using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Legs = 2;
            Eyes = 2;
        }
        public bool HasWings = true;
        public bool HasFeathers = true;
        public bool CanFly { get; set; }
        public bool HasTalons { get; set; }
    }
}
