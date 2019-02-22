namespace hwapp
{
	using System;
	using System.Collections.Generic;
	
	internal class CommandUser
	{
		private class CommandSet
		{
			public Type commandType;
			public ICommand command;
			public string path;
		}
		
		private Stack<CommandSet> history;
		
		private CommandSet currentCommandSet;
		private CommandSet cachedCommandSet;
		
		public CommandUser()
		{
			this.history = new Stack<CommandSet>();
			this.currentCommandSet = new CommandSet();
			this.cachedCommandSet = new CommandSet();
		}

		public Type CommandType
		{
			get
			{
				return this.currentCommandSet.commandType;
			}
			
			set
			{
				this.currentCommandSet.commandType = value;
				this.SetCommand(this.currentCommandSet.commandType);
			}
		}
		
		public void ExecuteCommand(string path)
		{
			this.currentCommandSet.path = path;
			this.currentCommandSet.command.Execute(path);
			this.history.Push(this.currentCommandSet);
		}
		
		public void Undo()
		{
			Console.WriteLine("Command : Undo");
			this.cachedCommandSet = this.history.Pop();
			Console.WriteLine(this.cachedCommandSet.commandType + " : undo ");
		}
		
		public void Redo()
		{
			Console.WriteLine("Command : Redo");
			this.history.Push(this.cachedCommandSet);
			this.cachedCommandSet.command.Execute(this.cachedCommandSet.path);
			Console.WriteLine(this.cachedCommandSet.commandType + " : Redo ");
		}
		
				
		private void SetCommand(Type type)
		{
			this.currentCommandSet.command = (ICommand)Activator.CreateInstance(type);
		}
		
	}
}