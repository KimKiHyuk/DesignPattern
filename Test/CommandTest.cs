namespace hwapp
{
	using System;
	
	public class CommandTest : ITestStep
	{
		
		public CommandTest()
		{
		
		}
		
		public void Run()
		{
			var obj = new CommandUser();
		}
		

	}

}