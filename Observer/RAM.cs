using System;
using System.Collections.Generic;

namespace hwapp
{
	internal class RAM : IObserver
	{	
		private SystemManager _systemManager;
		
		public RAM(SystemManager systemManager)
		{
			this._systemManager = systemManager;
		}
		
		public void Update()
		{
			Console.WriteLine("RAM information has been updated - " + this._systemManager.memoryOut);
		}
		
		public void UpdateByEvent(string message)
		{
			Console.WriteLine(string.Format("[{0}] RAM information has been updated - {1}", message,  this._systemManager.memoryOut));
		}
	}
}