namespace hwapp
{
	using System;
	public class KakaoAccount : ICash
	{
		public void Pay(uint money)
		{
			Console.WriteLine("From " + this + " gonna charge $" + money);
		}
	}
}