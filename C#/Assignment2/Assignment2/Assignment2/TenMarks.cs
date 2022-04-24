using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class TenMarks
    {
        public void marks()
        {
            int totalMarks = 0;
            int[] arr = new int[10];
            Console.WriteLine("Enter Your Marks");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("__________");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                totalMarks += arr[i];
            }
            Console.WriteLine("Total Marks = " + totalMarks);
            int average = totalMarks / arr.Length;
            Console.WriteLine("Average Marks = " + average);
           
            Console.WriteLine("Minimum marks = "+arr.Min());
           
            Console.WriteLine("Maximum marks = " + arr.Max());
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j=i+1;j<arr.Length; j++)
                {
                    if(arr[i]>arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }         
                }
            }
            Console.WriteLine("Ascending Order ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Descending Order ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
