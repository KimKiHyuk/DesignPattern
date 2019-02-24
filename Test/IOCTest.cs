namespace hwapp
{
	using System;
	
	public class IOCTest : ITestStep
	{	
		private Service<ServiceTemplate> memoryService;
		private Service<ServiceTemplate> powerService;
		private Service<ServiceTemplate> chromeService;
		private Service<ServiceTemplate> firefoxService;
		
		private Service<IHardwareService> memoryService2;
		private Service<IHardwareService> powerService2;
		private Service<ISoftwareService> chromeService2;
		private Service<ISoftwareService> firefoxService2;
		
		public IOCTest()
		{
			this.memoryService = new Service<ServiceTemplate>(typeof(MemoryManagementService));
			
			this.powerService = new Service<ServiceTemplate>(typeof(PowerManagementService));
			
			this.chromeService = new Service<ServiceTemplate>(typeof(ChromeManagementService));
			
			this.firefoxService = new Service<ServiceTemplate>(typeof(FireFoxManagementService));
			
			
			this.memoryService2 = new Service<IHardwareService>(typeof(MemoryManagementService));
			
			this.powerService2 = new Service<IHardwareService>(typeof(PowerManagementService));
			
			this.chromeService2 = new Service<ISoftwareService>(typeof(ChromeManagementService));
			
			this.firefoxService2 = new Service<ISoftwareService>(typeof(FireFoxManagementService));
		}
		
		public void Run()
		{	
			this.FullyRunHelper(this.memoryService);
			this.FullyRunHelper(this.powerService);
			this.FullyRunHelper(this.chromeService);
			this.FullyRunHelper(this.firefoxService);
			
			this.ParticiallyRunHelper("hardware");
			this.ParticiallyRunHelper("software");
		}
		
		private void FullyRunHelper(Service<ServiceTemplate> service)
		{		   
			Console.BackgroundColor = ConsoleColor.Blue;
        	Console.ForegroundColor = ConsoleColor.Black;
			Console.WriteLine("-------전체 테스트-------");
			Console.ResetColor();
			var instance = service.GetServiceInstance();
			Console.WriteLine("ServiceName : " + instance.GetType());
			instance.LoadService();
			instance.LoadApplication();	
		}
		
		private void ParticiallyRunHelper(string serviceType)
		{
		    Console.BackgroundColor = ConsoleColor.White;
        	Console.ForegroundColor = ConsoleColor.Black;
			Console.WriteLine("-------부분 테스트-------");
			Console.ResetColor();
			
			if (String.Equals(serviceType, "hardware"))
			{
				var instance = memoryService2.GetServiceInstance();	
				instance.LoadService();
				
				instance = powerService2.GetServiceInstance();
				instance.LoadService();
			}
			else if (String.Equals(serviceType, "software"))
			{
				var instance = chromeService2.GetServiceInstance();	
				instance.LoadApplication();
				
				instance = firefoxService2.GetServiceInstance();
				instance.LoadApplication();
			}
			else
			{
			
			}
		}
	}
}