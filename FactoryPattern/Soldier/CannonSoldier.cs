using System;

namespace hwapp
{
	public class CannonSoldier : SoldierTemplate
	{
		public CannonSoldier() : base()
		{
		}
		
		public CannonSoldier(string Name, string Classes, int DutyPeriod, string Nation)
		{
			this.Name = Name;
			this.Classes = Classes;
			this.DutyPeriod = DutyPeriod;
			this.Nation = Nation;
		}
		
		public override void GetReport()
		{
			Console.WriteLine("private report for " + this.Name);	
		}
	}
}