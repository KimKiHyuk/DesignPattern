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
				new SingletonTest(),
				new FactoryTest(),
				new AbstractFactoryTest(),
				new PrototypeTest()
			};
			
			foreach (var test in testCase)
			{
				test.Run();
			}
        }
    }
}
