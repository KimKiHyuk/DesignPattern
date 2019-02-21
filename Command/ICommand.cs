namespace hwapp
{
	using System;
	
	internal interface ICommand
	{
		void Execute(string path);
	}

}