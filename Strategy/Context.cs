using System;

namespace hwapp
{
	internal class Context
	{
		private IStrategy strategy = null;
		
		public Context()
		{
			this.Strategy = strategy;
		}
		
		public Context(IStrategy strategy)
		{
			this.Strategy = strategy;
		}
		
		public void RunStrategy()
		{
			this.Strategy?.Algorithm();
		}
		
		public IStrategy Strategy
		{
			get;
			set;
		}
	}
}