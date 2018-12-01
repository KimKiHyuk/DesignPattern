namespace hwapp
{
	using System;
	
	public class NavyPrototype : APrototype
	{	
		public NavyPrototype(int i) : base(i) {}
		
		public override APrototype Clone()
		{
			return this.MemberwiseClone() as NavyPrototype;
		}
	}
}