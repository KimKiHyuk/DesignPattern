using System;

namespace hwapp
{
	internal class Service
	{
		private ServiceLocator _locator;
		private IServiceCategory _category;
		
		public Service()
		{
			this._locator = new ServiceLocator();
		}
		
		public Service(IServiceCategory category) : this()
		{
			this._category = category;	
		}
		
		public Service(Type service) : this()
		{
			this._category = this._locator.LocateService(service);
		}
		
		
		public void GetServiceInstance()
		{
			this._category.LoadService();
		}
		

		
		private class ServiceLocator
		{
			public ServiceLocator()
			{
			}
			
			public IServiceCategory LocateService(Type service)
			{
				if (service == typeof(FileManagementService))
				{
					return new FileManagementService();
				}
				else if (service == typeof(MemoryManagementService))
				{
					return new MemoryManagementService();
				}
				
				return null;
			}
		}
	}
}