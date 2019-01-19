namespace hwapp
{
	using System;
	using System.Collections.Generic;
	
	public class StrategyTest : ITestStep
	{
		private List<IStrategy> strategyList;
		public StrategyTest()
		{
			this.strategyList = new List<IStrategy>()
			{
				new StrategyAlpha(),
				new StrategyBeta()
			};
		}
		
		public void Run()
		{
			Context ctx = new Context();

			foreach (var s in strategyList)
			{
				ctx.Strategy = s;
				ctx.RunStrategy();
			}
		}
	}
}