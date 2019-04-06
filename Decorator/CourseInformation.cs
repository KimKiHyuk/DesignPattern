using System;
	
namespace hwapp
{
	public class CourseInformation
	{
		public CourseInformation(string professor, int seat)
		{
			this.Professor = professor;
			this.Seat = seat;
		}
		
		public string Professor
		{
			get;
			private set;
		}
		
		public int Seat
		{
			get;
			private set;
		}
	}
}