using HelloWorld.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HelloWorld {
	class Program {
		static void Main(string[] args) {
			#region Creating Order
			//Customer customer = Customer.CreateCustomer("John", "Smith", "john@smith.com");
			//Product product = Product.CreateProduct(99.99, "Bike");
			//Product anotherProduct = Product.CreateProduct(999.99, "Guitar");

			//Order order = Order.CreateOrder(customer, product, 2);
			//order.AddProduct(anotherProduct, 1);

			//order.SaveOrder(@"C:\_test");
			#endregion

			// Loading order
			var order = Order.LoadOrder(@"C:\_test\Order_cc191113-cb07-47c3-a369-908962983b7e.xml");

			Console.WriteLine(order);
		}
	}
}