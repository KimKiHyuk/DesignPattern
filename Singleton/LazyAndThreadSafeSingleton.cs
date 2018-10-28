namespace hwapp
{
	using System;
	
	public sealed class LazyAndThreadSafeSingleton
	{
		private LazyAndThreadSafeSingleton()
		{
			Console.WriteLine("LazyAndThreadSafeSingleton Constructor invoked");
		}
		
		public static LazyAndThreadSafeSingleton Instance
		{
			get
			{
				return Nested.instance;
			}
		}
		
		private class Nested
		{
			static Nested()
			{
				Console.WriteLine("LazyAndThreadSafeSingleton -> Nested Constructor invoked");
			}
			
			internal static readonly LazyAndThreadSafeSingleton instance = new LazyAndThreadSafeSingleton();
		}
	}
}