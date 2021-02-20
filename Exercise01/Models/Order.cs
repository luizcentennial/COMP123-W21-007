using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01.Models {
	public class Order {
		public string OrderID { get; set; }
		public Customer Customer { get; set; }
		public DateTime RentalTime { get; set; }
		public string CreditCardNumber { get; set; }
		public double InsuranceFee { get; set; }
		public Car Car { get; set; }
		public int Days { get; set; }
		public double Total { 
			get {
				if (this.Car == null)
					throw new Exception("A car has not been included to this order yet.");

				return this.Car.DailyRate * this.Days + this.InsuranceFee;
			}
		}
	}
}
