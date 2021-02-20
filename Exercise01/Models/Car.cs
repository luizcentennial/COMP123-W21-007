using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01.Models {
	public class Car {
		public string CarID { get; private set; }
		public CarType Type { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public double DailyRate { get; set; }
		public string Description { get; set; }
		public string Plate { get; set; }

		public Car() {
			this.CarID = Guid.NewGuid().ToString();
		}

		public override string ToString() {
			return $"CarID: {this.CarID} \n" +
				   $"Daily Rate: {this.DailyRate:C} \n" +
				   $"Make: {this.Make} \n" +
				   $"Model: {this.Model} \n" +
				   $"Description: {this.Description}";
		}
	}
}
