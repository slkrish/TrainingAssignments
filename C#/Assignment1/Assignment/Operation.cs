using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Operation
    {
        public void operation()
        {
            int num1;
            int num2;
            char operation;
            Console.WriteLine("Input first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Operation");
            operation = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Input second number");
            num2 = Convert.ToInt32(Console.ReadLine()); 
          
            if (operation == '+')
                Console.WriteLine(+num1 + num2);
            else if (operation == '-')
                Console.WriteLine(num1 - num2);
            else if (operation == '*')
                Console.WriteLine(num1 * num2);
            else if (operation == '/')
                Console.WriteLine(num1 / num2);
            else
                Console.WriteLine("Wrong Operation");
            Console.Read();
        }

    }
}
