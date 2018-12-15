using System;

namespace hwapp
{
	internal interface IObserver
	{
		void UpdateByEvent(string message);
		
		void Update();
	}
}