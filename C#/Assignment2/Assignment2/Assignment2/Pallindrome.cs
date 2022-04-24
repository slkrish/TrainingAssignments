using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Pallindrome
    {
        public void pallindrome()
        {
            Console.WriteLine("Enter the String");
            string s1 = Convert.ToString(Console.ReadLine());
            string s2 = "";
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                s2 = s2 + s1[i];
            }
            if (s1==s2)
            {
                Console.WriteLine(s1+" is a pallindrome");
            }
            else
            {
                Console.WriteLine(s1 + " is not a pallindrome");
            }
        }
    }
}
