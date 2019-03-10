using System;

namespace hwapp
{
	public class CyberSoldier : SoldierTemplate
	{
		public CyberSoldier() : base()
		{
			
		}
		
		public CyberSoldier(string Name, string Classes, int DutyPeriod, string Nation) : base(Name, Classes, DutyPeriod, Nation)
		{
		}
		
		public override void GetReport()
		{
			Console.WriteLine("private report for " + this.Name);	
		}
	
	}
}