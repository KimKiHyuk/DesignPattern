using System;

namespace hwapp
{
	internal class Context
	{
		private IStragety stragety = null;
		
		public Context()
		{
			this.Stragety = stragety;
		}
		
		public Context(IStragety stragety)
		{
			this.Stragety = stragety;
		}
		
		public void RunStragety()
		{
			this.Stragety?.Algorithm();
		}
		
		public IStragety Stragety
		{
			get;
			set;
		}
	}
}