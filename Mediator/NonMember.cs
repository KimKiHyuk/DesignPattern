using System;
namespace hwapp
{
	internal class NonMember : Participant
	{
		public NonMember(string id) : base(id)
		{
		
		}
		
		public override void Receive(string message, string sender)
		{
			Console.WriteLine("- NonMember've got message");
			base.Receive(message, sender);
		}
	}
}