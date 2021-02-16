using System;
using System.Collections.Generic;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter first number:");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before:\nFist number: {firstNum}\nSecond number: {secondNum}\n");
            SwapTwoNums(firstNum, secondNum);


            ExerciseBreak("Is the year leap?");


            Console.WriteLine("Please input any year and press Enter");
            var userYearInput = Console.ReadLine();
            int givenYear = Int32.Parse(userYearInput);
            IfYearLeap(givenYear);


            ExerciseBreak("The Digital root");


            Console.WriteLine("Input the random number:");
            var userRandomNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine(DigitalRoot(userRandomNumber));


            Console.ReadLine();
        }

        static int DigitalRoot(int num)
        {
            int root = 0;

            // Loop to do sum while 
            // sum is not less than 
            // or equal to 9 
            while (num > 0 || root > 9)
            {
                if (num == 0)
                {
                    num = root;
                    root = 0;
                }

                root += num % 10;
                num /= 10;
            }
            return root;

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
                Console.WriteLine($"After:\n{i+1} value is: {finalNums[i]}");
            }
            
        }

        static void ExerciseBreak(string nameOfExercise)
        {
            Console.ReadLine();
            Console.WriteLine($"The next exercise is \"{nameOfExercise}\"");
            Console.ReadLine();
        }
    }
}
