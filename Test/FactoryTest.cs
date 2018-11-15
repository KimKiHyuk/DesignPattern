namespace hwapp
{
	using System;
	
	public class FactoryTest
	{
		public FactoryTest()
		{
			ISoldierFactory factory;
			
			factory = new SoldierFactory();
			
			for (int i = 0; i < 3; i++)
			{
				ASoldier soldier = factory.ConCreateSoldier(i);
				soldier.ActivateSoldier();
			}

		}
	}
}