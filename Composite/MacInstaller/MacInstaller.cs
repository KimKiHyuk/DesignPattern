using System;

namespace hwapp
{
	public class MacInstaller : Installer
	{
		public override void Operation()
		{
			Console.WriteLine(this);
		}
	}
}