using System;

namespace hwapp
{
	internal class FireFoxManagementService : ServiceTemplate
	{		
		override public void LoadApplication()
		{
        	Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Firefox service Loaded");
			Console.ResetColor();
		}
	}
}