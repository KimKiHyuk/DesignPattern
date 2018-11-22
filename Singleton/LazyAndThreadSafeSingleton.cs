namespace hwapp
{
	using System;
	
	public sealed class LazyAndThreadSafeSingleton
	{
		private LazyAndThreadSafeSingleton()
		{
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
			}
			
			internal static readonly LazyAndThreadSafeSingleton instance = new LazyAndThreadSafeSingleton();
		}
	}
}