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
				// Creational Patterns
				/*
				new FactoryTest(),
				new AbstractFactoryTest(),
				new SingletonTest(),
				new PrototypeTest(),
				new IOCTest(),
				*/
				
				// Structural Patterns
				/*
				new CompositeTest(),
				new ProxyTest(),
				new FacadeTest(),
				new AdaptorTest(),
				*/
				new DecoratorTest(),
				
				// Behavioral Patterns
				/*
				new IteratorTest(),
				new ObserverTest(),
				new StrategyTest(),
				new CommandTest(),
				*/
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
