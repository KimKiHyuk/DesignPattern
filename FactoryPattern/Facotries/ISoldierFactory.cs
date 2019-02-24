using System;

namespace hwapp
{
	public interface ISoldierFactory
	{
		SoldierTemplate GetSoldierInstance(Type type, string name, string classes, int dutyPeriod, string nation);
	}
}