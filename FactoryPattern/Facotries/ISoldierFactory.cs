using System;

namespace hwapp
{
	public interface ISoldierFactory
	{
		ISoldier ConCreateSoldier(int i);
	}
}