using System;
using System.Collections.Generic;

namespace hwapp
{
	public class Compositor : Component
	{
		private IList<Component> _installerList;
		
		public Compositor()
		{
			this._installerList = new List<Component>();
		}
		
		public override void Add(Component component) 
		{
			_installerList?.Add(component);
		}
		
		public override void Sub(Component component) 
		{
			_installerList?.Remove(component);
		}
		
		public override void Operation()
		{
			foreach (var _installer in _installerList)
			{
				_installer.Operation();
			}
		}
	}
}