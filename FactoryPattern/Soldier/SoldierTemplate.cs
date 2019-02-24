using System;

namespace hwapp
{	
	public abstract class SoldierTemplate
	{
		public SoldierTemplate()
		{
			this.Nation = "X";
			this.Name = "X";
			this.Classes = "X";
			this.DutyPeriod = 607;
			
		}
		protected string Nation
		{
			get;
			set;
		}
		
		protected string Name
		{
			get;	
			set;
		}
		
		protected string Classes
		{
			get;	
			set;
		}
		
		protected int DutyPeriod
		{
			get;
			set;
		}
		
		public virtual bool discharge(int period) => (607 - period) <= 0;
		
				
		
		public virtual void ShowMeYourTag()
		{
			Console.WriteLine("\n-이름 : {0}\n-병과 : {1}\n-국적 : {2}\n-전역 : {3}", 				this.Name, this.Classes, this.Nation, this.discharge(this.DutyPeriod));
		}
		
		public abstract void GetReport();
	}
}