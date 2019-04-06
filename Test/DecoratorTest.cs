using System;
	
namespace hwapp
{
	public class DecoratorTest : ITestStep
	{
		public DecoratorTest()
		{
		
		}
		
		public void Run()
		{
			Course systemProgram = new SystemProgramming();
			Course operatingSystem = new OperatingSystem();
			Course computerSeminar = new ComputerSeminar();
			
			IEWebSite user_1 = new IEWebSite("kim");
			
			user_1.Enrolment(systemProgram);
			user_1.Enrolment(operatingSystem);
			user_1.Enrolment(computerSeminar);
			user_1.GetCourse();
			
			ChromeWebSite user_2 = new ChromeWebSite("lee");
			
			user_2.Enrolment(systemProgram);
			user_2.Enrolment(operatingSystem);
			user_2.Enrolment(computerSeminar);
			user_2.GetCourse();
			
			IEWebSite user_3 = new IEWebSite("park");
			
			user_3.Enrolment(systemProgram);
			user_3.Enrolment(operatingSystem);
			user_3.Enrolment(computerSeminar);
			user_3.GetCourse();	
		}
	}

}