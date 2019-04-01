using System;

namespace hwapp
{
	public abstract class Component
	{
		public virtual void Add(Component component) {}
		
		public virtual void Sub(Component component) {}
		
		public abstract void Operation();
	}
}