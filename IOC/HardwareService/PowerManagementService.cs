using System;

namespace hwapp
{
	internal class PowerManagementService : ServiceTemplate
	{
		override public void LoadService()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Power service Loaded");
			Console.ResetColor();
		}
	}
}