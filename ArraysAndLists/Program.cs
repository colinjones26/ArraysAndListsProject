using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int array and populate it with numbers 1-10
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            /* Create a list of type int
             * Name the list "evens"
             */
            List<int> evens = new List<int>();


            /* Create another list of type int
             * Name the list "odds"
             */
            List<int> odds = new List<int>();


            // Using either a foreach or for loop,
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];

                //If the number is even, add it to the evens list.
                if (number % 2 == 0)
                {
                    evens.Add(number);
                }
                //If the number is odd, add it to the odds list.
                else
                {
                    odds.Add(number);
                }
            }

            //Using a foreach loop, even list
            Console.WriteLine("Even numbers:");
            foreach (int even in evens)
            {
                Console.WriteLine(even);
            }


            // Using a for loop, odds list
            Console.WriteLine("Odd numbers:");
            for (int i = 0; i < odds.Count; i++)
            {
                Console.WriteLine(odds[i]);
            }
        }
    }
}

