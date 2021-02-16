using System;
using System.Collections.Generic;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int firstNum = 4;
            int secondNum = 9;
            Console.WriteLine($"Fist number: {firstNum}\nSecond number: {secondNum}\n\n\n");
            SwapTwoNums(firstNum, secondNum);


            Console.ReadLine();


            Console.WriteLine("If year leap or no?");

            int givenYear = 2017;
            IfYearLeap(givenYear);
            Console.ReadLine();
        }

        static void IfYearLeap(int a)
        {
            var result = (a % 4 == 0) ? "leap" : "not leap";
            Console.WriteLine($"The year of {a} is {result}");
        }




        static void SwapTwoNums(int a, int b)
        {

            int c;
            c = a;
            a = b;
            b = c;
            int[] finalNums = { a, b };

            for (int i = 0; i < finalNums.Length; i++)
            {
                Console.WriteLine($"{i} value is: {finalNums[i]}\n");
            }
            
        }
    }
}
