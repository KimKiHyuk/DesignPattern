using System;

namespace hwapp
{	
	public class UserInformationAPI
	{
		protected string _data;
		
		public UserInformationAPI(string data)
		{
			this._data = data;
		}
		
		public virtual void Post()
		{
			Console.WriteLine("/Post\n\tname : " + _data);
		}
	}
}