using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class AppEngine
    {
        Student[] students;
        Course[] courses;
        Enroll[] enrolls;
        public int studentlistsize;
        public int courselistsize;
        public int enrolllistsize;
        public AppEngine()
        {
            this.students = new Student[100];
            this.courses = new Course[100];
            this.enrolls = new Enroll[100];
            this.studentlistsize = 0;
            this.courselistsize = 0;
            this.enrolllistsize = 0;
        }
        public void introduce(Course course)
        {
            courses[this.courselistsize] = course;
            courselistsize += 1;
        }
        public void register(Student student)
        {
            students[this.studentlistsize] = student;
            studentlistsize += 1;
        }
        public Student[] listOfStudents()
        {
            return students;
        }
        public Course[] listOfCourses()
        {
            return courses;
        }
        public void enroll(Student student, Course course)
        {
            Enroll enroll = new Enroll(student, course,new DateTime());
            enrolls[this.enrolllistsize] = enroll;
            this.enrolllistsize += 1;
        }
        public Enroll[] listOfEnrollments()
        {
            return this.enrolls;
        }
    }
}
