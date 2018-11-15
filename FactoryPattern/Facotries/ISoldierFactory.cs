using System;

namespace hwapp
{
	public interface ISoldierFactory
	{
		ASoldier ConCreateSoldier(int i);
	}
}