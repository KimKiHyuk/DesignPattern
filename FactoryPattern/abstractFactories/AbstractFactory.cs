using System;

namespace hwapp
{
	public abstract class AbstractFactory
	{	
		public virtual object GetInstance(Type type)
		{
			Console.WriteLine("\n======== Create Base");
			return Activator.CreateInstance(type);
		}
		public abstract object GetInstance(Type type, object param);
	}
}