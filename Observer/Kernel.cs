using System;
using System.Collections.Generic;
namespace hwapp
{
	internal abstract class Kernel
	{
		public delegate void NotifyHandler(string message);
	
		private event NotifyHandler NotifyEvent;
		
		List<IObserver> observedElements;
		
		public Kernel()
		{
			this.observedElements = new List<IObserver>();
		}
				
		public void Attach(IObserver observer)
		{
			this.observedElements.Add(observer);
		}
		
		public void AttachHandler(NotifyHandler handler)
		{
			this.NotifyEvent += handler;
		}
		
		public void Detach(IObserver observer)
		{
			this.observedElements.Remove(observer);	
		}
		
		public void DetachHandler(NotifyHandler handler)
		{
			this.NotifyEvent -= handler;
		}
		
		public void Notify()
		{
			foreach (var observer in observedElements)
			{
				observer.Update();
			}
		}
		
		public void Notify(string message)
		{
			if (NotifyEvent != null)
			{
				NotifyEvent(message);
			}
		}
	}
}