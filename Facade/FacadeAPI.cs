namespace hwapp
{
	using System;
	using System.Collections.Generic;
	
    public class FacadeAPI
    {
		private readonly IAPI systemAPI;
		private readonly IAPI userAPI;
			
		public FacadeAPI()
		{
			this.systemAPI = new SystemAPI();
			this.userAPI = new UserAPI();
		}
		
		public void SystemInitalize()
		{
			this.systemAPI.Initalize();
		}
		
		public void UserInitalize()
		{
			this.userAPI.Initalize();
		}
	}
}