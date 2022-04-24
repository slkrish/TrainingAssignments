using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayProgram arrayprogram = new ArrayProgram();
            arrayprogram.array();
            TenMarks tenmarks = new TenMarks();
            tenmarks.marks();
            String string1 = new String();
            string1.stringProgram();
            Pallindrome pallindrome = new Pallindrome();
            pallindrome.pallindrome();
            Console.Read();
        }
    }
}
