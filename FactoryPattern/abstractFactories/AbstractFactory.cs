using System;

namespace hwapp
{
	public abstract class AbstractFactory<T> where T : class
	{
		public virtual T GetInstance(Type type)
		{
			return (T)Activator.CreateInstance(type);
		}
	}
}