using Exercise02.Interfaces;
using Exercise02.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise02.Services {
	public class BirdService : IBirdService {
		public Bird GetBird(string birdID) {
			// Connecting to database...
			// Retrieving record from Bird table where BirdID = birdID
			// Let's assume the record found is for a FlyingBird.

			var bird = new FlyingBird() { 
				BirdID = birdID,
				Color = "Blue",
				Species = "Blue Jay",
				Speed = 40.0,
				Weight = 0.050
			};

			return bird;
		}
	}

	public class BirdFileService : IBirdService {
		public Bird GetBird(string birdID) {
			// Retrieving data from hard drive...
			// Let's assume the record found is for a FlyingBird.

			var bird = new FlyingBird() {
				BirdID = birdID,
				Color = "Blue",
				Species = "Blue Jay",
				Speed = 40.0,
				Weight = 0.050
			};

			return bird;
		}
	}
}
