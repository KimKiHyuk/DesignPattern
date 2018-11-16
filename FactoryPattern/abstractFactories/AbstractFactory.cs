using System;

namespace hwapp
{
	public class AbstractFactory : IAbstractFactory
	{		
		public ISoldierFactory ConCreateFactroy(int i)
		{
			if (i == 0)
			{
				return new KoreanSoldierFactory(); 
			}
			else if (i == 1)
			{
				return new AmericanSoldierFactory();
			}
			else
			{
				return new AmericanSoldierFactory();
			}
		}
	}
}