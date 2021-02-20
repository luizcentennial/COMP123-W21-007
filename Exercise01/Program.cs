using Exercise01.Models;
using System;

namespace Exercise01 {
	class Program {
		static void Main(string[] args) {
			/*
			 
			Implement a console app that will be used as a car rental system.

			Part A: Identify the key entities that will exist in your system.
			Once they have been identified, implement classed that represent them,
			including the appropriate properties, constructors, and ToString() method.

			*/

			var order = new Order();

			try {
				// This block includes code that may raise exceptions.
				// (Something may go wrong)
				Console.WriteLine("Calculating total...");

				Console.WriteLine(order.Total);

				// The line below is never reached if an exception is thrown above.
				Console.WriteLine("Total calculated!");
			}
			catch (Exception e) {
				// This block will ONLY run if an exception happens in the try block.
				Console.WriteLine(e.Message);
			}
			finally {
				// This block will run regardless of whether an exception happened in the try block.
				Console.WriteLine("The application has been terminated.");
			}
		}
	}
}
