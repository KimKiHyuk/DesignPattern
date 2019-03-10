namespace hwapp
{
	using System;
	using System.Collections.Generic;
	
    class Program
    {
        static void Main(string[] args)
        {
			List<ITestStep> testCase = new List<ITestStep>()
			{
			//	new SingletonTest(),
				new FactoryTest(),
				new AbstractFactoryTest(),
			//	new PrototypeTest(),
			//	new FacadeTest(),
			//	new IteratorTest(),
			//	new ObserverTest(),
			//	new IOCTest(),
			//	new StrategyTest(),
			//	new ProxyTest(),
			//	new CommandTest(),
			};
			
			foreach (var test in testCase)
			{
				Console.WriteLine("Test : " + test.GetType());
				test.Run();
				Console.WriteLine("======================");
				
			}
        }
    }
}
