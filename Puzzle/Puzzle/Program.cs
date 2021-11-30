using System;
using System.Collections.Generic;
using System.Linq;

namespace Puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> name = new List<string>();
            name.Add("Todd");
            name.Add("Tiffany");
            name.Add("Charlie");
            name.Add("Geneva");
            name.Add("Sydney");


            filterNames(name);
        }
        //Create a function called RandomArray() that returns an integer array
          public static void RandomArray()
        {
            Random r = new Random();
            List<int> randomList = new List<int>();
            int i = 0;
            while( i < 10){
                int genRand = r.Next(5, 25);
                randomList.Add(genRand);
                i++;
            }
            //Place 10 random integer values between 5-25 into the array
            //Print the min and max values of the array
            //Print the sum of all the values
            int min = randomList[0];
            int max = randomList[0];
            int sum = 0;
            foreach (int j in randomList)
            {
                if (j > max)
                {
                    max = j;
                }
                if (j < min)
                {
                    min = j;
                }
                sum = sum + j;
            }
            Console.WriteLine($"this is the max number {max}, This is the min number: {min}, This is the sum of all the numbers: {sum}");
        }
        public static void TossCoin(int toFlip)
        {
            //Have the function print "Tossing a Coin!"

            //Randomize a coin toss with a result signaling either side of the coin

            //Have the function print either "Heads" or "Tails"
            //Finally, return the result
            List<string> results = new List<string>();
            int flippedTimes = 0;
            Console.WriteLine("How many times do you want to flip the coin?");
            toFlip = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tossing a coin {toFlip} times");
            while(flippedTimes <= toFlip)
            {
                Random r = new Random();
                int genRand = r.Next(1, 3);
                if (genRand == 1)
                {
                    flippedTimes += 1;
                    results.Add("Heads");
                }
                else
                {
                    flippedTimes += 1;
                    results.Add("Tails");
                }
                
            }
                foreach (string i in results)
                {
                Console.WriteLine(i);
                }

            //Have the function call the tossCoin function multiple times based on num value
            //Have the function return a Double that reflects the ratio of head toss to total toss
        }
        public static List<string> filterNames(List<string> names)
        {
            //Build a function Names that returns a list of strings.  In this function:

            //Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
            //Shuffle the list and print the values in the new order
            List<string> shufflednames = names.OrderBy(a => Guid.NewGuid()).ToList();
            List<string> namesLongerThanFive = new List<string>();
            foreach(string i in shufflednames)
            {
                Console.WriteLine(i);
                if(i.Length > 5)
                {
                    namesLongerThanFive.Add(i);
                }
            }
            //Return a list that only includes names longer than 5 characters
            return namesLongerThanFive;
        }
    }
}
