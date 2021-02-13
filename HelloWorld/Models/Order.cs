using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Models {
	public class Order {
		// PROPERTIES
		public string OrderID { get; set; }
		public Customer Customer { get; set; }
		public List<OrderItem> Items { get; set; }
		public double Total {
			get {
				double total = 0;

				if (this.Items != null)
					foreach (var item in this.Items)
						total += item.SubTotal;

				return total;
			}
		}

		// METHODS
		private Order() {
			this.OrderID = Guid.NewGuid().ToString();
			this.Items = new List<OrderItem>();
		}

		public void AddProduct(Product product, int quantity = 1) {
			var item = OrderItem.CreateOrderItem(product, quantity);
			this.Items.Add(item);
		}

		public static Order CreateOrder(Customer customer, Product product, int quantity = 1) {
			var order = new Order();
			order.Customer = customer;

			var item = OrderItem.CreateOrderItem(product, quantity);

			order.Items.Add(item);

			return order;
		}

		public override string ToString() {
			return $"Order ID: {this.OrderID} \n" +
				   $"Customer: {this.Customer.FirstName} {this.Customer.LastName} \n" +
				   $"Total: {this.Total:C}";
		}
	}
}
