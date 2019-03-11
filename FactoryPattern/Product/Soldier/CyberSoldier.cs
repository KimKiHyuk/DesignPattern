using System;

namespace hwapp
{
	public class CyberSoldier : SoldierTemplate
	{
		public CyberSoldier() : base()
		{
			
		}
		
		public CyberSoldier(object data) : base(data)
		{
		}
		
		public override void GetReport()
		{
			Console.WriteLine("private report for " + this);	
		}
	
	}
}