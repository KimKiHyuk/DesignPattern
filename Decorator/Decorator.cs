using System;
using System.Collections.Generic;	
namespace hwapp
{
	public abstract class Decorator : Course
	{
		public IList<Course> enrolledCourse;
		
		public Decorator()
		{
		
		}
		
		public override void GetCourse()
		{
			foreach (var course in enrolledCourse)
			{
				course.GetCourse();
			}
		}
	}
}