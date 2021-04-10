using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise03.Models {
	public class Account {
		public string AccountGuid { get; set; }
		public string AccountNumber { get; set; }
		public string FullName { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public List<Transaction> Transactions { get; set; }
		public double Balance {
			get {
				double balance = 0;

				foreach (var transaction in this.Transactions) {
					if (transaction.IsCredit)
						balance += transaction.Value;
					else
						balance -= transaction.Value;
				}

				return balance;
			}
		}

		public Account() {
			this.AccountGuid = Guid.NewGuid().ToString();
			this.Transactions = new List<Transaction>();
			this.AccountNumber = new Random().Next(10000, 99999).ToString();
		}
	}
}
