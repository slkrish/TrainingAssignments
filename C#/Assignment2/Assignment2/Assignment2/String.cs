using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class String
    {
        public void stringProgram()
        {
            Console.WriteLine("Enter the string");
            string s1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(s1.Length);
            string s2 = "";
            for (int i =s1.Length-1; i >=0; i--)
            {
                s2 = s2 + s1[i];
            }
            Console.WriteLine(s2);
            Console.WriteLine("Enter first word");
            string first = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter second word");
            string second = Convert.ToString(Console.ReadLine());   
            if(first == second)
            {
                Console.WriteLine(first +" and "+second+" are same");
            }
            else
            {
                Console.WriteLine(first + " and " + second + " are not same");
            }
        }

    }
}
