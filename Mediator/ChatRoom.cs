using System;
using System.Collections.Generic;
namespace hwapp
{
	internal class ChatRoom : IChatRoom
	{
		private IDictionary<string, Participant> chatParticipant;
		
		
		public ChatRoom()
		{
			this.chatParticipant = new Dictionary<string, Participant>(); 
		}
		
		public void Send(string message, string sender, string receiver)
		{
			this.chatParticipant[receiver]?.Receive(message, sender);
		}
		
		public void RegisterUsers(params Participant[] users)
		{
			foreach (var user in users)
			{
				this.chatParticipant[user.Name] = user;
				this.chatParticipant[user.Name].ConnectedChatRoom = this;
			}
			
		}
	}
}