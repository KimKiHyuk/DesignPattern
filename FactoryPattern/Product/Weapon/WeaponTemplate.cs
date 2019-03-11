using System;

namespace hwapp
{	
	public abstract class WeaponTemplate
	{
		public WeaponTemplate()
		{
			this.data = new Data("X", "X");
		}
		
		public WeaponTemplate(object data)
		{
			this.data = data as Data;
		}
				

		public virtual void ShowMeYourTag()
		{
			Console.WriteLine("\n-이름 : {0}\n-생산 : {1}", this.data.Name, this.data.Produced);
		}
		
				
		protected Data data
		{
			get;
			set;
		}
		
		protected internal class Data
		{
			public Data(string Name, string Produced)
			{
				this.Name = Name;
				this.Produced = Produced;
			}
			
			public string Name
			{
				get;	
				set;
			}
		
			public string Produced
			{
				get;	
				set;
			}
		}
	}
}