using System;

namespace hwapp
{
	public class SoldierFactory : ISoldierFactory
	{
		public ISoldier ConCreateSoldier(int i)
		{
			if (i == 0)
			{
				return new CyberSoldier();
			}
			else if (i == 1)
			{
				return new MedicSoldier();
			}
			else
			{
				return new CannonSoldier();
			}
		}
	}
}