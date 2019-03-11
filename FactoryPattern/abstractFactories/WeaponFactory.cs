using System;

namespace hwapp
{
	public class WeaponFactory : AbstractFactory
	{
		public WeaponFactory()
		{
		
		}
		
		public override object GetInstance(Type type, object param)
		{
			Console.WriteLine("\n======== Create WeaponTemplate");
			return Activator.CreateInstance(type, param);
		}
	}
}