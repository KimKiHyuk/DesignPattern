using System;

namespace hwapp
{
	internal interface Iterator
	{
		object Current();
		object Next();	
		void Rewind();
	}
}