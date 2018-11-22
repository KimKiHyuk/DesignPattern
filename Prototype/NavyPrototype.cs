namespace hwapp
{
	using System;
	
	public class NavyPrototype : APrototype
	{	
		public NavyPrototype(int i) : base(i) {}
		
		public override APrototype Clone()
		{
			Console.WriteLine("========={0} Cloning...=============", this);
			return this.MemberwiseClone() as NavyPrototype;
		}
	}
}