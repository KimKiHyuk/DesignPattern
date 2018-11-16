namespace hwapp
{
	using System;
	
	public class AbstractFactoryTest
	{
		public AbstractFactoryTest()
		{
			IAbstractFactory Afactory = new AbstractFactory();
			
			for (int i = 0; i < 2; i++)
			{
				ISoldierFactory factory = Afactory.ConCreateFactroy(i);
				
				for (int j = 0; j < 3; j++)
				{
					ASoldier soldier = factory.ConCreateSoldier(j);
					soldier.ActivateSoldier();
				}
			}

		}
	}
}