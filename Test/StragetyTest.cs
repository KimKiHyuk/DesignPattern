namespace hwapp
{
	using System;
	using System.Collections.Generic;
	
	public class StragetyTest : ITestStep
	{
		private List<IStragety> stragetyList;
		public StragetyTest()
		{
			this.stragetyList = new List<IStragety>()
			{
				new StragetyAlpha(),
				new StragetyBeta()
			};
		}
		
		public void Run()
		{
			Context ctx = new Context();

			foreach (var s in stragetyList)
			{
				ctx.Stragety = s;
				ctx.RunStragety();
			}
		}
	}
}