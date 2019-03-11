using System;

namespace hwapp
{
	public class CannonSoldier : SoldierTemplate
	{
		public CannonSoldier() : base()
		{
		}
		
		public CannonSoldier(object data) : base(data)
		{
		}
		
		public override void GetReport()
		{
			Console.WriteLine("private report for " + this);	
		}
	}
}