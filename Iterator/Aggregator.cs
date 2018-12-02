using System;

namespace hwapp
{
	internal class Aggergator
	{
		private string[] dataList;
		
		public int arraySize
		{
			get;
			set;
		}
		
		public Aggergator(int arraySize)
		{
			this.arraySize = arraySize;
			this.dataList = new string[this.arraySize];
		}
		
		public Iterator GetIterator()
		{
			return new ConcreateIterator(this);
		}
		
		public string this[int index]
		{
			get
			{
				return this.dataList[index];
			}
			
			set
			{
				this.dataList[index] = value;
			}
		}
		
	}
}