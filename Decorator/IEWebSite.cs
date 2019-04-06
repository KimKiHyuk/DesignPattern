using System;
using System.Collections.Generic;
namespace hwapp
{
	public class IEWebSite : Decorator
	{
		private string name;
		
		public IEWebSite (string name) : base()
		{
			this.enrolledCourse = new List<Course>();
			this.name = name;
			Console.WriteLine("\n$user : " + this.name + " login\n");
		}
		
		public void Enrolment(Course course)
		{	
			// specified code for IE
			
			if (course.AvaliableSeat)
			{				
				this.enrolledCourse.Add(course);
				course.OccupiedSeat += 1;
			}
			else
			{
				Console.WriteLine("=======\n\t" + course + " enrolment is rejected\n=======");
			}
		}
		
		public void LoadActiveX()
		{
			Console.WriteLine("======= Load activeX for IE =======");
		}
		
		public override void GetCourse()
		{
			Console.WriteLine("* Check your enrolled courses");
			this.LoadActiveX();
			base.GetCourse();
		}
	}
}