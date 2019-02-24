using System;

namespace hwapp
{
	internal class ChromeManagementService : ServiceTemplate
	{		
		override public void LoadApplication()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Chrome service Loaded");
			Console.ResetColor();
		}
	}
}