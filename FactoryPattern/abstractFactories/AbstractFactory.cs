using System;

namespace hwapp
{
	public abstract class AbstractFactory<T> where T : class
	{
		public virtual T GetInstance(Type type)
		{
			Console.WriteLine("\n======== Create Base new template");
			return (T)Activator.CreateInstance(type);
		}
		
		public abstract T GetInstance(Type type, object param);
	}
}