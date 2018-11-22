namespace hwapp
{
	using System;
	
	public class PrototypeTest
	{
		public PrototypeTest()
		{
			APrototype army = new ArmyPrototype(1);
			APrototype navy = new NavyPrototype(2);
			
			Console.WriteLine("Object : {0}\nHash : {1}\nProcessID : {2}", army, army.GetHashCode(), army.ProcessID);
			
			army = army.Clone();
			Console.WriteLine("Object : {0}\nHash : {1}\nProcessID : {2}", army, army.GetHashCode(), army.ProcessID);
			
			Console.WriteLine("Object : {0}\nHash : {1}\nProcessID : {2}", navy, navy.GetHashCode(), navy.ProcessID);
			
			navy = navy.Clone();
			Console.WriteLine("Object : {0}\nHash : {1}\nProcessID : {2}", navy, navy.GetHashCode(), navy.ProcessID);


		}
	}
}			

