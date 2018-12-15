using System;
using System.Collections.Generic;

namespace hwapp
{
	internal class CPU : IObserver
	{
		private SystemManager _systemManager;
		
		public CPU(SystemManager systemManager)
		{
			this._systemManager = systemManager;
		}
		
		public void Update()
		{
			Console.WriteLine("CPU information has been updated - " + this._systemManager.cpuTemperature);
		}
		
		public void UpdateByEvent(string message)
		{
			Console.WriteLine(string.Format("[{0}] CPU information has been updated - {1}", message, this._systemManager.cpuTemperature));
		}
	}
}