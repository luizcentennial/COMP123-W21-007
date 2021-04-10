using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise03.Models {
	public class DebitTransaction : Transaction {
		public override bool IsCredit { get => false; }
	}
}
