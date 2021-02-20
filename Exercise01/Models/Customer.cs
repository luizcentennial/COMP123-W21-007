using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01.Models {
	public class Customer {
		public string CustomerID { get; private set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public List<DriversLicense> DriversLicenses { get; set; }
		public DateTime DateOfBirth { get; set; }

		public Customer() {
			this.CustomerID = Guid.NewGuid().ToString();
		}

		public override string ToString() {
			string info = $"Customer ID: {this.CustomerID} \n" +
						  $"Name: {this.FirstName} {this.LastName} \n" +
						  $"Date of Birth: {this.DateOfBirth:yyyy/MM/dd}";

			foreach (var license in this.DriversLicenses) 
				info += license.ToString();

			return info;
		}
	}
}
