using Exercise02.Interfaces;
using Exercise02.Models;
using Exercise02.Services;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise02 {
	class Program {
		static void Main(string[] args) {
			/*
			// Instantiating an object polymorphically
			Bird blueJay = new FlyingBird() {
				BirdID = "BIRD1",
				Color = "Blue",
				Species = "Blue Jay",
				Weight = 0.050
			};

			blueJay.Eat();
			((FlyingBird)blueJay).Fly();

			// Instantiating an object non-polymorphically
			RunningBird ostrich = new RunningBird() {
				BirdID = "BIRD2",
				Color = "Brown",
				Species = "Ostrich",
				Weight = 100
			};

			ostrich.Run();

			blueJay.Sleep();
			ostrich.Sleep();

			// =========================================================

			// Specialized lists
			List<FlyingBird> flyingBirds = new List<FlyingBird>();
			List<RunningBird> runningBirds = new List<RunningBird>();

			flyingBirds.Add((FlyingBird)blueJay);
			runningBirds.Add(ostrich);

			// Generalized/Polymorphic lists
			List<Bird> birds = new List<Bird>();
			birds.Add(blueJay);
			birds.Add(ostrich);

			// =========================================================

			// Using interfaces to polymorphically instantiate objects
			IFlyingBird test = new FlyingBird();


			// =========================================================
			*/

			IBirdService birdService = new BirdFileService();
			var databaseBird = birdService.GetBird("BIRD001");

			Console.WriteLine(databaseBird);
		}
	}
}
