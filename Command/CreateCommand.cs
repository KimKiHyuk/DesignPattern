namespace hwapp
{
	using System;
	
	internal class CreateCommand : ICommand
	{
		public void Execute(string path)
		{
			Console.WriteLine("Create " + path);
		}
	}
}