using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01.Models {
	public class DriversLicense {
		public string LicenseID { get; set; }
		public string AddressLine1 { get; set; }
		public string AddressLine2 { get; set; }
		public DateTime ExpirationDate { get; set; }
		public DateTime IssuedDate { get; set; }
		public Customer Customer { get; set; }

		public DriversLicense() {

		}

		public override string ToString() {
			return $"License Number: {this.LicenseID} \n" +
				   $"Expiration Date: {this.ExpirationDate} \n";
		}
	}
}
