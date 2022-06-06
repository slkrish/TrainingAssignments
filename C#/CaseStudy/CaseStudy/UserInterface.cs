using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CaseStudy
{
    public interface UserInterface
    {
        void showFirstScreen();
        void showStudentScreen();
        void showAdminScreen();
        void showAllStudentsScreen();
        void showStudentRegistrationScreen();
        void introduceNewCourseScreen();
        void showAllCoursesScreen();
        void updateCourseDetails();
        void viewAllEnrollments();


    }
  
    public class SMS : UserInterface
    {
        AppEngine appEngine;
        public SMS()
        {
            this.appEngine = new AppEngine();
        }
        public void introduceNewCourseScreen()
        {
            Console.WriteLine("Enter course id");
            int cid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter course name");
            string course = Console.ReadLine();
            Console.WriteLine("Enter course duration");
            int duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter course fee");
            double fee = Convert.ToInt32(Console.ReadLine());
            Course course1 = new Course(cid, course, duration, fee);
            appEngine.introduce(course1);
            Console.WriteLine("Course added succesfully");
            showAdminScreen();
        }

        public void showAdminScreen()
        {
            Console.WriteLine("Welcome to Admin Screen");
            Console.WriteLine("Enter \n1 To Introuduce new Course \n2 To Update Course Details \n3 To Student Enroll \n4 View all enrollments \n5 To Exit");
            int ip = Convert.ToInt32(Console.ReadLine());
            switch (ip)
            {
                case 1:
                    introduceNewCourseScreen();
                    break;
                case 2:
                    updateCourseDetails();
                    break;
                case 3:
                    studentEnroll();
                    break;
                case 4:
                    viewAllEnrollments();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                        Console.WriteLine("Invalid Input");
                        showAdminScreen();
                    break;
            }
        }

        public void showAllCoursesScreen()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr;
            Console.WriteLine("List of courses available");
            //foreach(var v in appEngine.listOfCourses())
            //{
            //    Info.display(v);
            //}
            try
            {
                con = SQLConnection.getcon();
                cmd = new SqlCommand("select * from course", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("course id :" + dr[0]);
                    Console.WriteLine("course name :" + dr[1]);
                    Console.WriteLine("course duration :" + dr[2]);
                    Console.WriteLine("course fees :" + dr[3]);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            showFirstScreen();
        }

        public void showAllStudentsScreen()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr;
            Console.WriteLine("List of Students registered");
            //foreach(var v in appEngine.listOfStudents())
            //{
            //    Info.display(v);
            //}
            try
            {
                
                con = SQLConnection.getcon();
                cmd = new SqlCommand("select * from Student", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("student id :" + dr[0]);
                    Console.WriteLine("student name :" + dr[1]);
                    Console.WriteLine("date of birth :" + dr[2]);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
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
                case 3:
                    if (op >= 4)
                    {
                        showFirstScreen();
                    }
                    break;
            }
        }

        public void showStudentRegistrationScreen()
        {
            Console.WriteLine("Enter Student Id");
            int sid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name");
            string sname = Console.ReadLine();
            Console.WriteLine("Enter DOB(dd/mm/yyyy)");
            string dob = Console.ReadLine();
            Student student = new Student(sid, sname, dob);
            appEngine.register(student);
            Console.WriteLine("Student registered succesfully");
            showStudentScreen();
        }

        public void showStudentScreen()
        {
            Console.WriteLine("Welcome to Student Screen");
            Console.WriteLine("Enter \n1 to Registration \n2 to Show all Courses \n3 to Show Students");
            int ip = Convert.ToInt32(Console.ReadLine());
            switch (ip)
            {
                case 1:
                    showStudentRegistrationScreen();
                    break;
                case 2:
                    showAllCoursesScreen();
                    break;
                case 3:
                    showAllStudentsScreen();
                    break;
                default:
                    Console.WriteLine("Enter valid input");
                    showStudentScreen();
                    break;

            }
        }
        public void studentEnroll()
        {
            Console.WriteLine("Enter sid");
            int sid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter course id");
            int cid = Convert.ToInt32(Console.ReadLine());
            Student student = appEngine.GetStudentById(sid);
            Course course = appEngine.GetCourseById(cid);
            if (student == null)
            {
                Console.WriteLine("no student available with id");
            }
            else
            {
                if (course == null)
                {
                    Console.WriteLine("no course available with id");
                }
                else
                {
                    appEngine.enroll(student, course);
                }
            }
        }
        public void viewAllEnrollments()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr;
            Console.WriteLine("All Enrollment Details");
            try
            {
                con = SQLConnection.getcon();
                cmd = new SqlCommand("select * from Enroll", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("student id :" + dr[0]);
                    Console.WriteLine("course id :" + dr[1]);
                    Console.WriteLine("date of enrollment :" + dr[2]);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void updateCourseDetails()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;

            Console.WriteLine("updating course details");
            try
            {
                con = SQLConnection.getcon();
                Console.WriteLine("Enter course id to update course");
                int cid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter course name:");
                string cname = Console.ReadLine();
                Console.WriteLine("Enter duration");
                int dur = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter fees");
                double fees = Convert.ToDouble(Console.ReadLine());
                cmd = new SqlCommand("update Course set Name =@name where Id=@cid", con);
                cmd.Parameters.AddWithValue("@name", cname);
                cmd.Parameters.AddWithValue("@dur", dur);
                cmd.Parameters.AddWithValue("@fee", fees);
                cmd.Parameters.AddWithValue("@cid", cid);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("record updated");
                }
                else Console.WriteLine("Not updated");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}


