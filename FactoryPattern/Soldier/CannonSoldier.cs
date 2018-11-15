using System;

namespace hwapp
{
	public class CannonSoldier : ASoldier
	{
		public CannonSoldier() : this("이대포", "포병", 608)
		{
		}
		public CannonSoldier(string Name, string Classes, int DutyPeriod)
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