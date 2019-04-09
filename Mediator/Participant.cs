using System;
namespace hwapp
{
	internal class Participant
	{
		private string id;
		
		public Participant(string id)
		{
			this.id = id;
		}
		
		public string Name
		{
			get
			{
				return id;
			}
		}
		
		public ChatRoom ConnectedChatRoom
		{
			get;
			set;
		}
		
		public void Send(string message, params string[] receivers)
		{
			foreach (var receiver in receivers)
			{
				this.ConnectedChatRoom.Send(message, id, receiver);	
			}
		}
		
		public virtual void Receive(string message, string sender)
		{
			Console.WriteLine(string.Format($"receiver : {id}\n\t{message} from {sender}"));
		}
		
	}
}