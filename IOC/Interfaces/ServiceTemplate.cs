using System;

namespace hwapp
{
	internal abstract class ServiceTemplate : IHardwareService, ISoftwareService
	{
		virtual public void LoadService()
		{
			Console.WriteLine(this.GetType() + " does not have LoadService()");
		}
		
		virtual public void LoadApplication()
		{
			Console.WriteLine(this.GetType() + " does not have LoadApplication()");
		}
	}
}