using HelloWorld.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld {
	class Program {
		static void Main(string[] args) {
			Product product = new Product("Bike", 300);
			product.ShippingMethod = ShippingMethod.Air;

			Console.WriteLine(product);
		}
	}
}