using System;

namespace hwapp
{	
	public abstract class ASoldier : ISoldier
	{
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
		
		public abstract void ActivateSoldier();
	}
}