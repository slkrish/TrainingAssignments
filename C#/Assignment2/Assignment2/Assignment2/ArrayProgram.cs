using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class ArrayProgram
    {
        public void array()
        {
            int sum = 0;
            Console.WriteLine("Enter Size of an Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter Values");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("_______");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                sum += arr[i];
            }
            int average = sum/ arr.Length;
            Console.WriteLine("Average Of an Array = "+average);
           
            Console.WriteLine("Minimum value of an array = " + arr.Min());
           
            Console.WriteLine("Maximum value of an array = " + arr.Max());
        }
    }
}
