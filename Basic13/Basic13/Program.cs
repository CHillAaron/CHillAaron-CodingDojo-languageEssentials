using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, -4, -2 };
            int[] avg = { 2, 10, 3 };
            int[] number = { 3, 1, 5, 7, 9, 7 };
            int[] num = { 2, 4, 5 };
            //MinMaxAverage(number);
            



        }
        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255.
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255.
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                    Console.WriteLine(i);
            }
        }
        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255, 
            int sum = 0;
            for (int i = 0; i <= 255; i++)
            {
                // but this time, also print the sum as you go. 
                sum = sum + i;
                Console.WriteLine($"New Number {i} : Sum {sum}");
                // For example, your output should be something like this:

                // New number: 0 Sum: 0
                // New number: 1 Sum: 1
                // New Number: 2 Sum: 3

            }
        }
        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
            foreach (int i in numbers)
            {
                Console.WriteLine($"The numbers in Array are:  {i}");
            }
        }
        public static void FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            int max = numbers[0];
            foreach (int i in numbers)
            {
                if (max < i)
                {
                    max = i;
                }
            }
            Console.WriteLine($"This is the max number: {max}");
        }
        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            int avg = 0;
            int sum = 0;
            foreach (int i in numbers)
            {
                sum = sum + i;

            }
            avg = sum / numbers.Length;
            Console.WriteLine($"This is the avg number: {avg}");
        }
        public static int[] OddArray()
        {

            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
            List<int> oddList = new List<int>();
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 == 0)
                {
                }
                    oddList.Add(i);
            }
            int[] oddArr = oddList.ToArray();
            return oddArr;
        }
        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            int count = 0;
            foreach (int i in numbers)
            {
                if (i > y)
                {
                    count++;
                }
            }
            return count;
        }
        public static void squarearrayvalues(int[] numbers)
        {
            List<int> squareList = new List<int>();
            // write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // for example, [1,5,10,-10] should become [1,25,100,100]
            foreach (int i in numbers)
            {
                squareList.Add(i * i);
            }
            int[] squareArr = squareList.ToArray();
            foreach (int i in squareArr)
            {
                Console.WriteLine(i);
            }
        }
        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            List<int> positiveList = new List<int>();
            foreach (int i in numbers)
            {
                if (i > 0)
                {
                    positiveList.Add(i);
                }
                else if (i < 0)
                {
                    positiveList.Add(0);
                }
            }
            foreach (int i in positiveList)
            {
                Console.WriteLine(i);
            }
        }
        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            int max = numbers[0];
            int min = numbers[0];
            int avg = numbers[0];
            int sum = 0;
            foreach (int i in numbers)
            {
                if (i > max)
                {
                    max = i;
                }
                if (i < min)
                {
                    min = i;
                }
                sum = sum + i;
                avg = sum / numbers.Length;

            }
            Console.WriteLine($"the max number is {max}, The min number is {min}, The average of all the numberrs is {avg}");

        }
    }
}
