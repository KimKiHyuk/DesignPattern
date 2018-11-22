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
			Console.WriteLine("======= Start FactoryTest ===========\n");
			ISoldierFactory factory;
			
			factory = new SoldierFactory();
			
			for (int i = 0; i < 3; i++)
			{
				ASoldier soldier = factory.ConCreateSoldier(i);
				soldier.ActivateSoldier();
			}
			
			Console.WriteLine("======= End FactoryTest ===========\n");
		}
	}
}