using System;
using System.Collections.Generic;
using System.Text;

namespace UpcastindvsDowncastingforPractise.Models {
	class LionFish : Fish {

		public string Poison;
		public override void Eat()
		{
			Console.WriteLine("small fishes");
		}

		public override void Swim()
		{
			Console.WriteLine("Swim so faster");
		}
	}
}