namespace hwapp
{
	using System;
	public class UriAccount : ICash
	{
		public void Pay(uint money)
		{
			Console.WriteLine("From " + this + " gonna charge $" + money);
		}
	}
}