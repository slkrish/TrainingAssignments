using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
   public interface UserInterface
    {
		 void showFirstScreen();
		 void showStudentScreen();
		 void showAdminScreen();
		 void showAllStudentsScreen(); //admin
		 void showStudentRegistrationScreen(); //student
		 void introduceNewCourseScreen(); //admin
		 void showAllCoursesScreen(); // sudent&admin
	}
	
	public class SMS : UserInterface
    {
        AppEngine appEngine;
        int studentidseq;
        int courseseq;
        public SMS()
        {
            this.appEngine = new AppEngine();
            this.studentidseq = 1;
            this.courseseq = 10;
        }
        public void introduceNewCourseScreen()
        {
            Console.WriteLine("Enter course name");
            string course = Console.ReadLine();
            Console.WriteLine("Enter course duration");
            int duration =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter course fee");
            double fee = Convert.ToInt32(Console.ReadLine());
            Course course1 = new Course(courseseq,course,duration,fee);
            appEngine.introduce(course1);
            courseseq++;
            Console.WriteLine("Course added succesfully");
            showAdminScreen();
        }

        public void showAdminScreen()
        {
            Console.WriteLine("Welcome to Admin Screen");
            Console.WriteLine("Enter 1 to Show all Students 2 to Add new Course 3 to Show Courses 4 to enroll sudent");
            int ip = Convert.ToInt32(Console.ReadLine());
            switch(ip)
            {
                case 1:
                    showAllStudentsScreen();
                    break;
                case 2: introduceNewCourseScreen();
                    break;
                case 3:
                    showAllCoursesScreen();
                    break;
                case 4:
                    studentEnroll();
                    break;
                default: Console.WriteLine("Enter valid input");
                    showAdminScreen();
                    break;
                    
            }
        }

        public void showAllCoursesScreen()
        {
            Console.WriteLine( "List of courses available");
            foreach(var v in appEngine.listOfCourses())
            {
                Info.display(v);
            }
            showFirstScreen();
        }

        public void showAllStudentsScreen()
        {
            Console.WriteLine("List of Students registered");
            foreach(var v in appEngine.listOfStudents())
            {
                Info.display(v);
            }
            showAdminScreen();
        }

        public void showFirstScreen()
		{
			Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");
			Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin");
			Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
			int op = Convert.ToInt32(Console.ReadLine());

			switch (op)
			{
				case 1:
					showStudentScreen();
					break;
				case 2:
					showAdminScreen();
					break;
                default: Console.WriteLine("Enter valid input");
                    showFirstScreen();
                    break;
                    
			}
		}

        public void showStudentRegistrationScreen()
        {
            Console.WriteLine("Enter Student Name");
            string sname = Console.ReadLine();
            Console.WriteLine("Enter DOB(dd/mm/yyyy)");
            string dob = Console.ReadLine();
            Student student = new Student(studentidseq,sname,dob);
            appEngine.register(student);
            studentidseq++;
            Console.WriteLine("Student registered succesfully");
            showStudentScreen();
        }

        public void showStudentScreen()
        {
            Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0 Student Screen");
            Console.WriteLine("Enter 1 to Registration 2 to Show all Courses");
            int ip = Convert.ToInt32(Console.ReadLine());
            switch (ip)
            {
                case 1:
                    showStudentRegistrationScreen();
                    break;
                case 2:
                    showAllCoursesScreen();
                    break;
                default: Console.WriteLine("Enter valid input");
                    showStudentScreen();
                    break;
                    
            }
        }
        public  void studentEnroll()
        {
            Console.WriteLine("Enter sid");
            int sid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter course id");
            int cid = Convert.ToInt32(Console.ReadLine());
            Student student = appEngine.GetStudentById(sid);
            Course course = appEngine.GetCourseById(cid);
            if(student==null)
            {
                Console.WriteLine("no student available with id");
            }
            else
            {
                if(course==null)
                {
                    Console.WriteLine("no course available with id");
                }
                else
                {
                    appEngine.enroll(student, course);
                }
            }
        }
    }
}
