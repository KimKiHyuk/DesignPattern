using System;

namespace hwapp
{
	public class CannonSoldier : ISoldier
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