using System;

namespace hwapp
{	
	public abstract class SoldierTemplate
	{
		public SoldierTemplate()
		{
			this.data = new Data("X", "X", "X", -1);
		}
		
		public SoldierTemplate(object data) // for single factory
		{
			this.data = data as Data;
		}
			
		public virtual bool discharge(int period) => (607 - period) <= 0;
		
		public virtual void ShowMeYourTag()
		{
			Console.WriteLine("\n-이름 : {0}\n-병과 : {1}\n-국적 : {2}\n-전역 : {3}", 	this.data.Name, this.data.Classes, this.data.Nation, this.discharge(this.data.DutyPeriod));
		}
		
		public abstract void GetReport();
		
		protected Data data
		{
			get;
			set;
		}
		
		
		protected internal class Data
		{
			public Data(string Name, string Classes, string Nation, int DutyPeriod)
			{
				this.Name = Name;
				this.Classes = Classes;
				this.Nation = Nation;
				this.DutyPeriod = DutyPeriod;
			}
			
			public string Nation
			{
				get;
				set;
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
		}
	}
}