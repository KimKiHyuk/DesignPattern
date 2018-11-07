using System;

namespace hwapp
{	
	public interface ISoldier
	{
		string Name
		{
			get;	
			set;
		}
		string Classes
		{
			get;	
			set;
		}
		
		int DutyPeriod
		{
			get;
			set;
		}
		
		
		bool discharge();
		
	}
}