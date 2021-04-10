using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise03.Models {
	public class CreditTransaction : Transaction {
		public override bool IsCredit { 
			get {
				return true;
			}
		}
	}
}
