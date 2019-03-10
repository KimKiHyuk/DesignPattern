namespace hwapp
{
	using System;
	
	public class FactoryTest : ITestStep
	{
		private ISoldierFactory nonsanCamp;
		
		public FactoryTest()
		{
			this.nonsanCamp = new SoldierFactory();		
		}
		
		public void Run()
		{
			this.RunHelper(typeof(CyberSoldier), "김사이버", "SW개발", 608, "대한민국");
			this.RunHelper(typeof(CannonSoldier), "김포병", "관측", 500, "대한민국");
			this.RunHelper(typeof(MedicSoldier), "김의무", "간호", 2, "대한민국");
		}
		
		private void RunHelper(Type type, string name, string classes, int duty, string nation)
		{
			SoldierTemplate soldier = nonsanCamp.GetSoldierInstance(type, name, classes, duty, nation);
			
			soldier.ShowMeYourTag();
			soldier.GetReport();
		}
	}
}