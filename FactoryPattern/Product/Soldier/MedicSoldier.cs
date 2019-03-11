using System;

namespace hwapp
{
	public class MedicSoldier : SoldierTemplate
	{
		public MedicSoldier() : base()
		{
		}
		
		public MedicSoldier(object data) : base(data)
		{
		}
		
		public override void GetReport()
		{
			Console.WriteLine("private report for " + this);	
		}
	}
}