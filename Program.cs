using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Task_Discrete_Mathematics_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x,y, sum = 0;
            Console.Write("Enter the  start number :");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the end number:");
            int end = int.Parse(Console.ReadLine());

            // first loop to determine the start and end number taken from user
            for (int number = start; number <= end; number++)
            {
                // seconed to determine the divider start and end 
                for (int divider = 1; divider <= end; divider++)
                {
                    //first condition to make sure "number" can be divided on the "divider"
                    if (number % divider == 0)
                    {
                        // here we count how many times the "number" was divided 
                        sum += 1;
                    }
                }
                // seconed condition to make sure the "number" was divided two times only
                if (sum == 2)
                {
                    Console.WriteLine("is prime number : "+number);                
                }
                sum = 0;
            }
            



        }
    }
}

