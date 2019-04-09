namespace hwapp
{
	internal interface IChatRoom
	{
		void Send(string message, string sender, string receiver);
		
		void RegisterUsers(params Participant[] users);
	}
}