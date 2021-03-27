using Exercise02.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise02.Interfaces {
	public interface IBirdService {
		public Bird GetBird(string birdID);
		
		// Other methods here for the other CRUD operations.
	}
}
