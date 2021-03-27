using Exercise02.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise02.Models {
	public class FlyingBird : Bird, IFlyingBird {
		public double Speed { get; set; }

		public void Fly() {
			Console.WriteLine("Bird is flying...");
			this.name = "Steve";
		}

		public override void Sleep() {
			// Some specialized implementation here.
			Console.WriteLine("Flying bird sleeps.");
		}
	}
}
