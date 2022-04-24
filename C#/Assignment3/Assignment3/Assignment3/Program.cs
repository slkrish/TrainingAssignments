using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is for student program

             Student student = new Student();
             student.displayResult();
             student.displayData();
            Console.WriteLine("___________________");

            // This is for car program

              Car car = new Car(1234,"GTR","Sports");
              car.showDetails();
              car.Carno = 9531;
              car.Carname = "Mustang";
              car.Cartype = "muscle";
              Console.WriteLine("After changes");
              Console.WriteLine($"car no is {car.Carno} carname is {car.Carname} and cartype is {car.Cartype} and cost is {car.Cost} ");
            Console.WriteLine("____________________");
            //This is for loan program

            Console.WriteLine("Enter the amount");
           double amount = Convert.ToInt32(Console.ReadLine());
            Loan loan = new Loan();
            loan.loanCalcuator(amount);
            Console.Read();

        }
    }
}
