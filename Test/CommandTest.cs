namespace hwapp
{
	using System;
	
	public class CommandTest : ITestStep
	{
		
		public CommandTest()
		{
		
		}
		
		public void Run()
		{
			
			var user = new CommandUser();
			
			user.CommandType = typeof(CreateCommand);
			user.ExecuteCommand("/path/main/submodule.hpp");
			
			user.CommandType = typeof(DeleteCommand);
			user.ExecuteCommand("/path/main/main.cpp");
			
			user.Undo();
			user.Redo();

			
		}
		

	}

}