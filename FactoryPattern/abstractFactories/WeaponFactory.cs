using System;

namespace hwapp
{
	public class WeaponFactory<T> : AbstractFactory<T> where T : class
	{
		public WeaponFactory()
		{
		
		}
		
		public T GetInstance(Type type, string name, string produced)
		{
			return (T)Activator.CreateInstance(type, name, produced);
		}
	}
}