using System;

namespace hwapp
{
	public class CampNonSanFactory : AbstractFactory
	{
		public CampNonSanFactory()
		{
		
		}
		
		public override T GetInstance<T>(Type type, object param)
		{
			Console.WriteLine("\n======== Create SoldierTemplate");
			return (T)Activator.CreateInstance(type, param);
		}
		
	}
}