using System;

namespace hwapp
{	
	public abstract class WeaponTemplate
	{
		public WeaponTemplate()
		{
			this.Name = "X";
			this.Produced = "X";
		}
		
		public WeaponTemplate(string Name, string Produced)
		{
			this.Name = Name;
			this.Produced = Produced;
		}
		
		protected string Name
		{
			get;	
			set;
		}
		
		protected string Produced
		{
			get;	
			set;
		}

		public virtual void ShowMeYourTag()
		{
			Console.WriteLine("\n-이름 : {0}\n-생산 : {1}", this.Name, this.Produced);
		}
	}
}