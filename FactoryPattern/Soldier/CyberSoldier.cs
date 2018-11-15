using System;

namespace hwapp
{
	public class CyberSoldier : ASoldier
	{
		public CyberSoldier() : this("김싸사", "정보통신", 330)
		{
		}
		public CyberSoldier(string Name, string Classes, int DutyPeriod)
		{
			this.Name = Name;
			this.Classes = Classes;
			this.DutyPeriod = DutyPeriod;
		}
		
		public override void ActivateSoldier()
		{
			// something polymorphism things
			Console.WriteLine("--- info ---- \n-이름 : {0}\n-병과 : {1}", this.Name, this.Classes);
			Console.WriteLine("전역 가능? : " + this.discharge(this.DutyPeriod));
		}
	
	}
}