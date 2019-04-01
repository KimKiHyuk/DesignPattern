using System;

namespace hwapp
{
	public class X86Installer : Installer
	{
		public override void Operation()
		{
			Console.WriteLine(this);
		}
	}
}