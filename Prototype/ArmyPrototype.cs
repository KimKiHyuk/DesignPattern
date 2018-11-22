namespace hwapp
{
	using System;
	
	public class ArmyPrototype : APrototype
	{	
		public ArmyPrototype(int i) : base(i) {}
		
		public override APrototype Clone()
		{
			Console.WriteLine("========={0} Cloning...=============", this);
			return this.MemberwiseClone() as ArmyPrototype;
		}
	}
}