namespace hwapp
{
	using System;
	
	public class AbstractFactoryTest : ITestStep
	{
		AbstractFactory<SoldierTemplate> nonsan;
		AbstractFactory<WeaponTemplate> weapon;
		
		public AbstractFactoryTest()
		{
			this.nonsan = new CampNonSanFactory<SoldierTemplate>();
			this.weapon = new WeaponFactory<WeaponTemplate>();
		}
		
		public void Run()
		{	
			var instance_of_nonsan = this.nonsan.GetInstance(typeof(CyberSoldier), new SoldierTemplate.Data("김사이버", "SW개발", "대한민국", 700));
			instance_of_nonsan.ShowMeYourTag();
			
			instance_of_nonsan = this.nonsan.GetInstance(typeof(CyberSoldier));
			instance_of_nonsan.ShowMeYourTag();
			
			var instance_of_weapon = this.weapon.GetInstance(typeof(Rifie), new WeaponTemplate.Data("K-2", "대한민국"));
			instance_of_weapon.ShowMeYourTag();
			
			instance_of_weapon = this.weapon.GetInstance(typeof(Rifie));
			instance_of_weapon.ShowMeYourTag();
			
		}
	}
}