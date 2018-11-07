using System;

namespace hwapp
{
	public class CyberSoldier : ISoldier
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