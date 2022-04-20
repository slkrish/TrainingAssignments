using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Equal
    {
        public void equal()
        {
            int num1;
            int num2;
            Console.WriteLine("Enter number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            num2 = Convert.ToInt32(Console.ReadLine()); 
            if(num1 == num2)
            {
                Console.WriteLine(num1 + " and " + num2 + " are equal");
            }
            else
            {
                Console.WriteLine(num1 + " and " + num2 + " are not equal");
            }
            Console.Read();

        }
    }
}
