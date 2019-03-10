using System;

namespace hwapp
{
	public class CannonSoldier : SoldierTemplate
	{
		public CannonSoldier() : base()
		{
		}
		
		public CannonSoldier(string Name, string Classes, int DutyPeriod, string Nation) : base(Name, Classes, DutyPeriod, Nation)
		{
		}
		
		public override void GetReport()
		{
			Console.WriteLine("private report for " + this);	
		}
	}
}