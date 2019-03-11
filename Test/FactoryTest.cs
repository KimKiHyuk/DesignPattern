namespace hwapp
{
	using System;
	
	public class FactoryTest : ITestStep
	{
		private SoldierFactory nonsanCamp;
		
		public FactoryTest()
		{
			this.nonsanCamp = new SoldierFactory();		
		}
		
		public void Run()
		{
			this.RunHelper(typeof(CyberSoldier), new SoldierTemplate.Data("김사이버", "SW개발", "대한민국", 608));
			this.RunHelper(typeof(CannonSoldier), new SoldierTemplate.Data("김포병", "관측", "대한민국", 500));
			this.RunHelper(typeof(MedicSoldier), new SoldierTemplate.Data("김의무", "간호", "대한민국", 2));
		}
		
		private void RunHelper(Type type, object param)
		{
			SoldierTemplate soldier = nonsanCamp.GetSoldierInstance(type, param);		
			soldier.ShowMeYourTag();
			soldier.GetReport();
		}
	}
}