﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise03.Models {
	public abstract class Transaction {
		protected double value;

		public string TransactionGuid { get; set; }
		public double Value { 
			get {
				return this.value;
			}
			set {
				if (value >= 0)
					this.value = value;
				else
					throw new Exception("Transaction value cannot be null!");
			}
		}
		public DateTime Date { get; set; }
		public abstract bool IsCredit { get; }

		public Transaction() {
			this.TransactionGuid = Guid.NewGuid().ToString();
			this.Date = DateTime.Now;
		}
	}
}
