using System;

namespace hwapp
{
	public class MedicSoldier : ASoldier
	{
		public MedicSoldier() : this("박붕대", "의무", 212)
		{
		}
		public MedicSoldier(string Name, string Classes, int DutyPeriod)
		{
			this.Name = Name;
			this.Classes = Classes;
			this.DutyPeriod = DutyPeriod;
			this.Nation = string.Empty;
		}
		
		public MedicSoldier(string Name, string Classes, int DutyPeriod, string Nation)
		{
			this.Name = Name;
			this.Classes = Classes;
			this.DutyPeriod = DutyPeriod;
			this.Nation = Nation;
		}
		
		public override void ActivateSoldier()
		{
			// something polymorphism things
			Console.WriteLine("\n-이름 : {0}\n-병과 : {1}\n-국적 : {2}\n-전역 : {3}", 				this.Name, this.Classes, this.Nation, this.discharge(this.DutyPeriod));
		}
	}
}