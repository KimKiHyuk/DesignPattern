using System;

namespace hwapp
{
	public class SoldierFactory
	{
		public SoldierTemplate GetSoldierInstance(Type type, string name, string classes, int dutyPeriod, string nation)
		{	
			return (SoldierTemplate)Activator.CreateInstance(type, name, classes, dutyPeriod, nation);
		}
	}
}