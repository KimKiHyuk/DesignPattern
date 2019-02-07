namespace hwapp
{
	using System;
	public class CreditCard : ICash
	{
		private ICash cash;
		
		public CreditCard(Type cash)
		{
			if (cash == typeof(KakaoAccount))
			{
				this.cash = new KakaoAccount();
			}
			else if (cash == typeof(UriAccount))
			{
				this.cash = new UriAccount();
			}
		}
		
		public void Pay(uint money)
		{
			this.cash.Pay(money);
		}
	}
}