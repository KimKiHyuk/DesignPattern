using System;

namespace hwapp
{
	public class SoldierFactory : ISoldierFactory
	{
		public SoldierTemplate GetSoldierInstance(Type type, string name, string classes, int dutyPeriod, string nation)
		{	
			return (SoldierTemplate)Activator.CreateInstance(type, name, classes, dutyPeriod, nation);
		}
	}
}