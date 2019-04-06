using System;
using System.Collections.Generic;

namespace hwapp
{
	public class ChromeWebSite : Decorator
	{
		private string name;
		
		public ChromeWebSite (string name) : base()
		{
			this.enrolledCourse = new List<Course>();
			this.name = name;
			Console.WriteLine("\n$user : " + this.name + " login\n");
		}
		
		public void Enrolment(Course course)
		{
			// specified code for chrome
			
			if (course.AvaliableSeat)
			{
				this.enrolledCourse.Add(course);
				course.OccupiedSeat += 1;
			}
			else
			{
				Console.WriteLine("========\n\t" + course + " enrolment is rejected\n=======");
			}
		}
		
		public void LoadChromePlugin()
		{
			Console.WriteLine("======= Load plugin for chrome =======");
		}
		
		public override void GetCourse()
		{
			Console.WriteLine("* Check your enrolled courses");
			this.LoadChromePlugin();
			base.GetCourse();
		}
	}
}