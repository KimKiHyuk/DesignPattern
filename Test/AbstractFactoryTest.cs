namespace hwapp
{
	using System;
	
	public class AbstractFactoryTest : ITestStep
	{
		AbstractFactory camp;
		
		public AbstractFactoryTest()
		{
		}
		
		public void Run()
		{
			this.camp = new CampNonSanFactory();
			var instance_of_nonsan = this.camp.GetInstance(typeof(CyberSoldier), new SoldierTemplate.Data("김사이버", "SW개발", "대한민국", 700)) as SoldierTemplate;
			instance_of_nonsan.ShowMeYourTag();
			
			instance_of_nonsan = this.camp.GetInstance(typeof(CyberSoldier)) as SoldierTemplate;
			instance_of_nonsan.ShowMeYourTag();
			
			this.camp = new WeaponFactory();
			var instance_of_weapon = this.camp.GetInstance(typeof(Rifie), new WeaponTemplate.Data("K-2", "대한민국")) as WeaponTemplate;
			instance_of_weapon.ShowMeYourTag();
			
			instance_of_weapon = this.camp.GetInstance(typeof(Rifie)) as WeaponTemplate;
			instance_of_weapon.ShowMeYourTag();
			
		}
	}
}