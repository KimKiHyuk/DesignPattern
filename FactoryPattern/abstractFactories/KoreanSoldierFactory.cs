using System;

namespace hwapp
{
	public class KoreanSoldierFactory :  ISoldierFactory
	{
		public ASoldier ConCreateSoldier(int i)
		{
			if (i == 0)
			{
				return new CyberSoldier("김싸사", "정보통신", 154, "korean");
			}
			else if (i == 1)
			{
				return new MedicSoldier("이의무", "의무", 10, "korean");
			}
			else
			{
				return new CannonSoldier("박포병", "포병", 300, "korean");
			}
		}
	}
}