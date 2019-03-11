using System;

namespace hwapp
{
	public class CampNonSanFactory : AbstractFactory
	{
		public CampNonSanFactory()
		{
		
		}
		
		public override object GetInstance(Type type, object param)
		{
			Console.WriteLine("\n======== Create SoldierTemplate");
			return Activator.CreateInstance(type, param);
		}
		
	}
}