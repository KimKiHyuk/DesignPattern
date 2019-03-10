using System;

namespace hwapp
{
	public class Grenade : WeaponTemplate
	{
		public Grenade() : base()
		{
		}
		
		public Grenade(string Name, string Produced) : base(Name, Produced)
		{
		}
	}
}