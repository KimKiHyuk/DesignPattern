namespace hwapp
{
	using System;
	
	public class ObserverTest : ITestStep
	{
		
		public ObserverTest()
		{
		
		}
		
		public void Run()
		{
			SystemManager manager = new SystemManager();
			
			manager.Attach(new CPU(manager));
			manager.Attach(new RAM(manager));
			
			
			manager.cpuTemperature = 50;
			manager.memoryOut = true;			
			manager.Notify();
			
			manager.AttachHandler(new CPU(manager).UpdateByEvent);
			manager.AttachHandler(new RAM(manager).UpdateByEvent);
			
			manager.Notify("notice message");
		}
		
		
	}
}