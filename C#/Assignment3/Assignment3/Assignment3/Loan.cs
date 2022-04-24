using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Loan
    {
        double interest5;
        double interest7;
        double interest10;
            public void loanCalcuator(double amount)
            {
                interest5 = amount * 0.05;
                interest7 = amount * 0.07;
                interest10 = amount * 0.1;
                Console.WriteLine("5% interest = " + interest5);
                Console.WriteLine("7% interest = " + interest7);
                Console.WriteLine("10% interest = " + interest10);
            }
    }
}
