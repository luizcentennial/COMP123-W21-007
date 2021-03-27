using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise02.Models {
	public abstract class Bird {
		protected string name;

		public string BirdID { get; set; }
		public string Color { get; set; }
		public string Species { get; set; }
		public double Weight { get; set; }

		public void Eat() {
			Console.WriteLine("Bird is eating...");
		}

		public abstract void Sleep();

		public override string ToString() {
			return $"Bird ID: {this.BirdID} \n" +
				   $"Color: {this.Color} \n" +
				   $"Species: {this.Species}";
		}
	}
}
