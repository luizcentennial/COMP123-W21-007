using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise02.Models {
	public class RunningBird : Bird {
		public double Speed { get; set; }

		public void Run() {
			Console.WriteLine("Bird is running...");
		}

		public override void Sleep() {
			// Some specialized implementation here.
			Console.WriteLine("Running bird sleeps.");
		}
	}
}
