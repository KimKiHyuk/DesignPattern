namespace hwapp
{
	using System;
	
	public class SingletonTest
	{
		private readonly LazyAndThreadSafeSingleton newInstance_1;
		private readonly LazyAndThreadSafeSingleton newInstance_2;
		
		public SingletonTest()
		{
			this.newInstance_1 = LazyAndThreadSafeSingleton.Instance;
			this.newInstance_2 = LazyAndThreadSafeSingleton.Instance;
			
			if (newInstance_1 == newInstance_2)
			{
				Console.WriteLine("Singleton instances are same");
			}
			else
			{
				Console.WriteLine("Singleton instances are NOT same");
			}
		}
	}
}