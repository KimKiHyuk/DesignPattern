namespace hwapp
{
	using System;
	
	public class CompositeTest : ITestStep
	{
		
		public CompositeTest()
		{
		
		}
		
		public void Run()
		{
			var masterCompositor = new Compositor();
			var windowsInstallerCompositor = new Compositor();
			var linuxInstallCompositor = new Compositor();
			var macInstallerCompositor = new Compositor();
			
			windowsInstallerCompositor.Add(new X86Installer());
			windowsInstallerCompositor.Add(new X64Installer());
			
			windowsInstallerCompositor.Operation();
			
			linuxInstallCompositor.Add(new LinuxInstaller());
			
			linuxInstallCompositor.Operation();
			
			macInstallerCompositor.Add(new MacInstaller());
			
			macInstallerCompositor.Operation();
			
			Console.WriteLine("Total install start");
			masterCompositor.Add(windowsInstallerCompositor);
			masterCompositor.Add(linuxInstallCompositor);
			masterCompositor.Add(macInstallerCompositor);
			
			masterCompositor.Operation();
			
			
			
			
		}
		

	}

}