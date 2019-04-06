using System;

namespace hwapp
{	
	public class UserInformationLegacyAPI : UserInformationAPI
	{
		private DataProviderCompanay _oldData;
		
		public UserInformationLegacyAPI(string data) : base(data)
		{
			this._oldData = new DataProviderCompanay();
		}
		
		public override void Post()
		{
			base.Post();
			Console.WriteLine("\tlen : " + this._oldData.GetUserLength(_data));
		}
	}
}