using System;

namespace hwapp
{
	public class CampNonSanFactory<T> : AbstractFactory<T> where T : class
	{
		public CampNonSanFactory()
		{
		
		}
		
		public override T GetInstance(Type type, object param)
		{
			Console.WriteLine("\n======== Create SoldierTemplate");
			return (T)Activator.CreateInstance(type, param);
		}
		
	}
}