using System;

namespace hwapp
{
	public class MedicSoldier : ISoldier
	{
		public MedicSoldier() : this("박붕대", "의무", 212)
		{
		}
		public MedicSoldier(string Name, string Classes, int DutyPeriod)
		{
			this.Name = Name;
			this.Classes = Classes;
			this.DutyPeriod = DutyPeriod;
		}
		
		public string Name
		{
			get;	
			set;
		}
		public string Classes
		{
			get;	
			set;
		}
		
		public int DutyPeriod
		{
			get;
			set;
		}
		
		public bool discharge() => (607 - this.DutyPeriod) <= 0;		
	}
}