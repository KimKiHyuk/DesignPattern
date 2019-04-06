using System;
	
namespace hwapp
{
	public abstract class Course
	{
		private int occupiedSeat;
		
		public Course()
		{
			
		}
		
		public Course(CourseInformation courseInformation)
		{
			this.Information = courseInformation;
		}
		
		public CourseInformation Information
		{
			get;
			private set;
		}
		
		public bool AvaliableSeat
		{
			get
			{
				if (this.Information.Seat - this.OccupiedSeat > 0)
				{
					return true;	
				}
				
				return false;
			}
		}
		
		public int OccupiedSeat
		{
			get
			{
				return this.occupiedSeat;
			}
			
			set
			{
				if (this.AvaliableSeat)
				{
					this.occupiedSeat = value;
				}
			}
		}
		
		
		public virtual void GetCourse()
		{
			Console.WriteLine(String.Format("Course : {0}\nProfessor : {1}\nRemained seat : {2}", this, this.Information.Professor, this.Information.Seat - this.OccupiedSeat));
		}
	}
}