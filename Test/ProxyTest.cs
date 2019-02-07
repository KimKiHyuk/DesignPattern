namespace hwapp
{
	using System;
	
	public class ProxyTest : ITestStep
	{		
		public ProxyTest()
		{

		}
		
		public void Run()
		{
			CreditCard card = new CreditCard(typeof(KakaoAccount));
			
			card.Pay(1000);
			
			card = new CreditCard(typeof(UriAccount));
			
			card.Pay(2000);
			
			
			
			
		}
	}
}			

