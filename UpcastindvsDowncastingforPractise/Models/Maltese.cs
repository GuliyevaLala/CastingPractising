using System;
using System.Collections.Generic;
using System.Text;

namespace UpcastindvsDowncastingforPractise.Models {
	class Maltese : Dog {
		public string Fur;
		public override void Bark()
		{
			Console.WriteLine("Dog is barking");
		}

		public override void Eat()
		{
			Console.WriteLine("Pedigree");
		}
	}
}