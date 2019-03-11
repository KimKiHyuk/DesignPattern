using System;

namespace hwapp
{
	public class SoldierFactory
	{
		public SoldierTemplate GetSoldierInstance(Type type, object param)
		{	
			return (SoldierTemplate)Activator.CreateInstance(type, param);
		}
	}
}