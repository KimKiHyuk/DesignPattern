using System;
using System.Collections.Generic;

namespace hwapp
{
	internal class SystemManager : Kernel
	{	
		private uint _cpuTemperature;
		private bool _memoryOut;
		
		public uint cpuTemperature
		{
			get
			{
				return this._cpuTemperature;
			}
			
			set
			{
				this._cpuTemperature = value;
			}
		}
		
		public bool memoryOut
		{
			get
			{
				return this._memoryOut;
			}
			
			set
			{
				this._memoryOut = value;
			}
		}
		
		public SystemManager()
		{
			
		}	
	}
}