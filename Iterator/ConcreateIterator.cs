using System;

namespace hwapp
{
	internal class ConcreateIterator : Iterator
	{
		private Aggergator aggergator;
		
		private int pointer;
		
		public ConcreateIterator(Aggergator aggergator)
		{
			this.aggergator = aggergator;
		}
		
		
		public object Current()
		{
			if (this.aggergator.arraySize <= pointer)
			{
				return null;
			}
			
			return this.aggergator[pointer];
		}
		
		public object Next()
		{
			this.pointer += 1;
			return this.Current();
		}	
		
		public void Rewind()
		{
			this.pointer = 0;
		}
	}
}