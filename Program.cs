/*
Deficient Numbers - Easy from Coding Challenges
by Silvio Duka

Last modified date: 2018-03-12

A number is considered deficient if the sum of its factors is less than twice that number. 

For Example: 
10 is a deficient number. 
Factors of 10 are 1, 2, 5, 10 
Sum is 1 + 2 + 5 + 10 = 18 < 2 * 10 

Tasks: 
(Easy) Write a program to verify whether a given number is deficient or not. 
(Medium) Write a program to find all the deficient numbers in a range. 
(Hard) Given a number, write a program to display its factors, their sum and then verify whether it's deficient or not. . 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeficientNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10; // Insert a number to verify

            Console.WriteLine($"Number {number} {((SumFact(number) < 2 * number) ? "is" : "is NOT")} deficient number.");
        }

        static int SumFact(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}