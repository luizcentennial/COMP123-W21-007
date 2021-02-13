using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Models {
	public class Product {
		// FIELDS
		private int stock;

		// PROPERTIES
		public string ProductID { get; private set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public int Stock { 
			get {
				return this.stock;
			}
			set {
				if (value >= 0)
					this.stock = value;
			}
		}
		public bool IsInStock {
			get {
				return this.Stock > 0;
			}
		}
		public double Weight { get; set; }
		public ShippingMethod ShippingMethod { get; set; }

		// METHODS
		private Product(string description, double price) {
			this.ProductID = Guid.NewGuid().ToString();
			this.Description = description;
			this.Price = price;
		}

		public override string ToString() {
			return $"Product ID: {this.ProductID} \n" +
				   $"Description: {this.Description} \n" +
				   $"Price: {this.Price:C} \n" +
				   $"Shipping Method: {this.ShippingMethod}";
		}

		public static Product CreateProduct(double price, string description) {
			var product = new Product(description, price);

			// Some fancy business logic here.

			return product;
		}
	}
}
