namespace hwapp
{	
	using System;
	
    public class UserAPI : IAPI
    {
		
		public UserAPI()
		{
			
		}
		
		public void Initalize()
		{
			this.UserAccountLoader();
		}
		
		private void UserAccountLoader()
		{
			Console.WriteLine("USER Loaded by facade");
		}
	}
}