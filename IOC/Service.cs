using System;

namespace hwapp
{
	internal class Service<T> where T : class
	{
		private ServiceLocator _locator;
		private T _category;
		
		public Service()
		{
			this._locator = new ServiceLocator();
		}
		
		public Service(Type service) : this()
		{
			this._category = (T)this._locator.LocateService(service);
		}
		
		
		public T GetServiceInstance()
		{
			return _category;
		}
		

		
		private class ServiceLocator
		{
			public ServiceLocator() {}
			
			public T LocateService(Type service)
			{
				return (T)Activator.CreateInstance(service);
			}
		}
	}
}