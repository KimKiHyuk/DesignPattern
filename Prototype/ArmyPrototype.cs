namespace hwapp
{
	using System;
	
	public class ArmyPrototype : APrototype
	{	
		public ArmyPrototype(int i) : base(i) {}
		
		public override APrototype Clone()
		{
			return this.MemberwiseClone() as ArmyPrototype;
		}
	}
}