namespace hwapp
{
	using System;
	
	public class FacadeTest : ITestStep
	{
		
		public FacadeTest()
		{
		
		}
		
		public void Run()
		{
			FacadeAPI facade = new FacadeAPI();
			
			facade.SystemInitalize();
			facade.UserInitalize();
		}
	}
}