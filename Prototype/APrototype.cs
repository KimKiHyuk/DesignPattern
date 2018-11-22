namespace hwapp
{
	using System;
	
	public abstract class APrototype
	{
		public int ProcessID { get; set; }
		
		public APrototype(int id)
		{
			ProcessID = id;
		}
		
		public abstract APrototype Clone();		
	}
}