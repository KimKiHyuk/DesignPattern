using System;
namespace hwapp
{
	internal class Member : Participant
	{
		public Member(string id) : base(id)
		{
		
		}
		
		public override void Receive(string message, string sender)
		{
			Console.WriteLine("- Member've got message");
			base.Receive(message, sender);
		}
	}
}