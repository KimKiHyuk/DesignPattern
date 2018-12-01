namespace hwapp
{
	using System;
	
    public class SystemAPI : IAPI
    {
		public SystemAPI()
		{
			
		}
			
		public void Initalize()
		{
			this.KernelLoader();
		}
		
		private void KernelLoader()
		{
			Console.WriteLine("SYSTEM Loaded by facade");
		}
	}
}