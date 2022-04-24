using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Student
    {
        public int marksOfAll = 0;
        public string result;
        public int rollNo;
        public string name;
        public int Class;
        public int semester;
        public string branch;
        int[] marks = new int[5];
        public Student()
        {
            rollNo = 26;
            name = "Krishna";
            Class = 2;
            semester = 4;
            branch = "MECH";
        }
        public void displayResult()
        {
            Console.WriteLine("Enter marks");
          for(int i = 0; i < marks.Length; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
          for(int i = 0; i < marks.Length; i++)
            {
                if(marks[i] <35 )
                {
                    result = "failed";
                }
                marksOfAll += marks[i];
            }
            int   avgMarks = marksOfAll / marks.Length;
            if (marksOfAll > 35 && avgMarks < 50)
            {
                result = "failed";

            }
            if(avgMarks >50)
            {
                result = "passeed";
            }

        }
        public void displayData()
        {
            Console.WriteLine("Student name is "+name);
            Console.WriteLine("student rollno is "+rollNo);
            Console.WriteLine("student class is "+Class);
            Console.WriteLine("semester is "+semester);
            Console.WriteLine("branch is " + branch);
            Console.WriteLine("result is " + result);

        }
    }
}
