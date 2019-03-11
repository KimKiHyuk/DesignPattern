using System;

namespace hwapp
{
	public class WeaponFactory<T> : AbstractFactory<T> where T : class
	{
		public WeaponFactory()
		{
		
		}
		
		public override T GetInstance(Type type, object param)
		{
			Console.WriteLine("\n======== Create WeaponTemplate");
			return (T)Activator.CreateInstance(type, param);
		}
	}
}