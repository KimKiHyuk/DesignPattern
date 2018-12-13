namespace hwapp
{
	using System;
	
	public class IOCTest : ITestStep
	{	
		private FileManagementService _fileService;
		private MemoryManagementService _memoryService;
		
		public IOCTest()
		{
			this._fileService = new FileManagementService();
			this._memoryService = new MemoryManagementService();
		}
		
		public void Run()
		{
			Service fileService = new Service(_fileService);
			Service memoryService = new Service(_memoryService);
			
			
			Service fileServiceByLocator = new Service(typeof(FileManagementService));
			Service memoryServiceByLocator = new Service(typeof(MemoryManagementService));
			
			
			fileService.GetServiceInstance();
			memoryService.GetServiceInstance();
			
			fileServiceByLocator.GetServiceInstance();
			memoryServiceByLocator.GetServiceInstance();
		}
	}
}