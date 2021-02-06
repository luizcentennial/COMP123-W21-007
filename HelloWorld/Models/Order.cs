using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Models {
	public class Order {
		// PROPERTIES
		public string OrderID { get; set; }
		public Customer Customer { get; set; }
		public List<OrderItem> Items { get; set; }
		public double Total { get; set; }

		// METHODS
	}
}
