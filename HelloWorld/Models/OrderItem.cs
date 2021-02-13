using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Models {
	public class OrderItem {
		public string OrderItemID { get; set; }
		public Product Product { get; set; }
		public int Quantity { get; set; }
		public double SubTotal { 
			get {
				return this.Product.Price * this.Quantity;
			}
		}

		private OrderItem(Product product, int quantity = 1) {
			this.OrderItemID = Guid.NewGuid().ToString();
			this.Product = product;
			this.Quantity = quantity;
		}

		public static OrderItem CreateOrderItem(Product product, int quantity = 1) {
			var item = new OrderItem(product, quantity);

			// Some fancy business logic here...

			return item;
		}
	}
}
