using System;
using System.Collections.Generic;
using System.Text;

namespace UpcastindvsDowncastingforPractise.Models {
    public abstract class Animal {
        public string Name { get; set; }

        public abstract void Eat();
    }
}