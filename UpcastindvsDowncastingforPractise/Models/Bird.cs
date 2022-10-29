using System;
using System.Collections.Generic;
using System.Text;

namespace UpcastindvsDowncastingforPractise.Models {
    class Bird : Animal {
        public string Color { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eagle is eating");
        }
    }
}
