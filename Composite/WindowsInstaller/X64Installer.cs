using System;

namespace hwapp
{
	public class X64Installer : Installer
	{
		public override void Operation()
		{
			Console.WriteLine(this);
		}
	}
}