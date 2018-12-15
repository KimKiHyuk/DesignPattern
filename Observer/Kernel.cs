using System;
using System.Collections.Generic;
namespace hwapp
{
	internal abstract class Kernel
	{
		public delegate void NotifyHandler(string message);
	
		private event NotifyHandler NotifyEvent;
		
		private List<IObserver> observedElements;
		
		public Kernel()
		{
			this.observedElements = new List<IObserver>();
		}
				
		public virtual void Attach(IObserver observer)
		{
			this.observedElements.Add(observer);
		}
		
		public virtual void AttachHandler(NotifyHandler handler)
		{
			this.NotifyEvent += handler;
		}
		
		public virtual void Detach(IObserver observer)
		{
			this.observedElements.Remove(observer);	
		}
		
		public virtual void DetachHandler(NotifyHandler handler)
		{
			this.NotifyEvent -= handler;
		}
		
		public virtual void Notify()
		{
			foreach (var observer in observedElements)
			{
				observer.Update();
			}
		}
		
		public virtual void Notify(string message)
		{
			if (NotifyEvent != null)
			{
				NotifyEvent(message);
			}
		}
	}
}