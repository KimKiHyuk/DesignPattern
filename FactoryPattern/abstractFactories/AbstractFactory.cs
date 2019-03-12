using System;

namespace hwapp
{
	public abstract class AbstractFactory
	{	
		public virtual T GetInstance<T>(Type type) where T : class
		{
			Console.WriteLine("\n======== Create Base");
			return (T)Activator.CreateInstance(type);
		}
		public abstract T GetInstance<T>(Type type, object param) where T : class;
	}
}