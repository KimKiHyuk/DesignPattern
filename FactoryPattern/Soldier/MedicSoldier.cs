using System;

namespace hwapp
{
	public class MedicSoldier : SoldierTemplate
	{
		public MedicSoldier() : base()
		{
		}
		
		public MedicSoldier(string Name, string Classes, int DutyPeriod, string Nation) : base(Name, Classes, DutyPeriod, Nation)
		{
		}
		
		public override void GetReport()
		{
			Console.WriteLine("private report for " + this.Name);	
		}
	}
}