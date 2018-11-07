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
				ISoldier soldier = factory.ConCreateSoldier(i);
				Console.WriteLine(
					string.Format("이름 : {0}, 병과 : {1}, 전역 가능 : {2}", soldier.Name, soldier.Classes, soldier.discharge()));
			}

		}
	}
}