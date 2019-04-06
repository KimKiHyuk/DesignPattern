using System;
	
namespace hwapp
{
	public class AdaptorTest : ITestStep
	{		
		public AdaptorTest()
		{

		}
		
		public void Run()
		{
			UserInformationAPI api = new UserInformationAPI("김철수");
			UserInformationAPI legacyApi = new UserInformationLegacyAPI("박산다라");
			
			api.Post();
			legacyApi.Post();
		}
	}
}			

