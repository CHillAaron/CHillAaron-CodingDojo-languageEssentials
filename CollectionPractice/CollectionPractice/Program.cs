using System;
using System.Collections.Generic;

namespace CollectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array to hold integer values 0 through 9
            int[] numArr = { 0,1, 2, 3, 4, 6, 7, 8, 9 };
            //Create an array of the names "Tim", "Martin", "Nikki", &"Sara"
            string[] nameArr = {"Tim", "Martin", "Nikki", "Sara" };
            //Create an array of length 10 that alternates between true and false values, starting with true
            Boolean[] booArr = { true, false, true, false, true, false, true, false, true, false };

            for (int i = 0; i < booArr.Length; i++)
            {
                //Console.WriteLine($"The number is {numArr[i]}");
            }

            //Create a list of ice cream flavors that holds at least 5 different flavors(feel free to add more than 5!)
            List<string> iceCreamArr = new List<string>();
            iceCreamArr.Add("Chocolate");
            iceCreamArr.Add("Vanilla");
            iceCreamArr.Add("Strawberry");
            iceCreamArr.Add("Rocky Road");
            iceCreamArr.Add("Mint Chocolatechip");
            iceCreamArr.Add("Butter Pecan");
            //Output the length of this list after building it
            Console.WriteLine($"This is the length of the List: {iceCreamArr.Count}");
            //Console.WriteLine($"this is the length of the ice cream array {iceCreamArr.Count}");
            
            
            //Output the third flavor in the list, then remove this value
            //Console.WriteLine($"This is the third flavor {iceCreamArr[2]}");
            iceCreamArr.RemoveAt(3);
            //Output the new length of the list(It should just be one fewer!)
            //Console.WriteLine($"this is the length of the ice cream array {iceCreamArr.Count}");

        }
    }
}
