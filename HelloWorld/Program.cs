using HelloWorld.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld {
	class Program {
		static void Main(string[] args) {
			Customer customer = Customer.CreateCustomer("John", "Smith", "john@smith.com");
			Product product = Product.CreateProduct(99.99, "Bike");
			Product anotherProduct = Product.CreateProduct(999.99, "Guitar");

			Order order = Order.CreateOrder(customer, product, 2);
			order.AddProduct(anotherProduct, 1);

			Console.WriteLine(order);
		}
	}
}