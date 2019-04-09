namespace hwapp
{
	internal class MediatorTest : ITestStep
	{
		public void Run()
		{
			ChatRoom chatRoom = new ChatRoom();
			
			Participant kim = new Member("kim");
			Participant lee = new Member("lee");
			Participant park = new NonMember("park");
			
			chatRoom.RegisterUsers(kim, lee, park);
			
			kim.Send("hi lee", lee.Name);
			lee.Send("hello there", kim.Name);
			lee.Send("hello too, park", park.Name);
			park.Send("hello everybody", lee.Name, kim.Name);
		}
	}
}