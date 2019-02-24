using System;

namespace hwapp
{
	internal class MemoryManagementService : ServiceTemplate
	{	
		override public void LoadService()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Memory service Loaded");
			Console.ResetColor();
		}
	}
}