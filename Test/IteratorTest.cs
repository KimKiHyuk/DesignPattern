namespace hwapp
{
	using System;
	
	public class IteratorTest : ITestStep
	{
		
		public IteratorTest()
		{
		
		}
		
		public void Run()
		{
			int arraySize = 10;
			Aggergator aggregator = new Aggergator(arraySize);
			
			for (int loop = 0; loop < arraySize; loop++)
			{
				aggregator[loop] = "Text - " + loop;
			}

			Iterator i = aggregator.GetIterator();
			
			while (i.Current() != null)
			{
				Console.WriteLine(i.Current());
				i.Next();
			}
		}
	}
}