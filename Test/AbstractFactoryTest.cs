namespace hwapp
{
	using System;
	
	public class AbstractFactoryTest : ITestStep
	{
		CampNonSanFactory<SoldierTemplate> nonsan;
		WeaponFactory<WeaponTemplate> weapon;
		
		public AbstractFactoryTest()
		{
			this.nonsan = new CampNonSanFactory<SoldierTemplate>();
			this.weapon = new WeaponFactory<WeaponTemplate>();
		}
		
		public void Run()
		{
			var instance = this.nonsan.GetInstance(typeof(CyberSoldier), "김사이버", "SW개발", 32, "대한민국");
			instance.ShowMeYourTag();
			
			var instance1 = this.nonsan.GetInstance(typeof(CyberSoldier));
			instance1.ShowMeYourTag();
			
			var instance2 = this.weapon.GetInstance(typeof(Rifie), "K-2", "대한민국");
			instance2.ShowMeYourTag();
			
			var instance3 = this.weapon.GetInstance(typeof(Rifie));
			instance3.ShowMeYourTag();
		}
	}
}