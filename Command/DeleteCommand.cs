namespace hwapp
{
	using System;
	
	internal class DeleteCommand : ICommand
	{
		public void Execute(string path)
		{
			Console.WriteLine("Delete " + path);
		}
	}

}