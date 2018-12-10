using System;
using System.Collections.Generic;
namespace hwapp
{
	internal abstract class Kernel
	{
		List<IObserver> observedElements;
		
		public Kernel()
		{
			this.observedElements = new List<IObserver>();
		}
				
		public void Attach(IObserver observer)
		{
			this.observedElements.Add(observer);
		}
		
		public void Detach(IObserver observer)
		{
			this.observedElements.Remove(observer);	
		}
		
		public void Notify()
		{
			foreach (var observer in observedElements)
			{
				observer.Update();
			}
		}
	}
}