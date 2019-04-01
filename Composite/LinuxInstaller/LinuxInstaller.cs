using System;

namespace hwapp
{
	public class LinuxInstaller : Installer
	{
		public override void Operation()
		{
			Console.WriteLine(this);
		}
	}
}