using System;

namespace hwapp
{
	public class WeaponFactory : AbstractFactory
	{
		public WeaponFactory()
		{
		
		}
		
		public override T GetInstance<T>(Type type, object param)
		{
			Console.WriteLine("\n======== Create WeaponTemplate");
			return (T)Activator.CreateInstance(type, param);
		}
	}
}