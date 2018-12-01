namespace hwapp
{
	using System;
	
	public class FactoryTest : ITestStep
	{
		public FactoryTest()
		{
		
		}
		
		public void Run()
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