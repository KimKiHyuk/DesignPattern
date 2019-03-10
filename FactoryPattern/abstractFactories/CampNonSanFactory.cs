using System;

namespace hwapp
{
	public class CampNonSanFactory<T> : AbstractFactory<T> where T : class
	{
		public CampNonSanFactory()
		{
		
		}
		
		public T GetInstance(Type type, string name, string classes, int dutyPeriod, string nation)
		{
			return (T)Activator.CreateInstance(type, name, classes, dutyPeriod, nation);
		}
	}
}