using System;
using System.Collections.Generic;
//Consecutive duplicate element from array
namespace DuplicateElementFromArray
{
    class Program
    {

        static void Main(string[] args)
        {
            string array = "geeksforgeeks";
            System.Console.Write("final output: ");
            System.Console.WriteLine(duplicate(array));

        }

        public static string duplicate(string array)
        {
            List<char> results = new List<char>();
            foreach (var element in array)
            {

                if (results.Count == 0 || results.FindLast((element) => element == element) != element)
                {
                    results.Add(element);
                }
            }
            string finalOutput = new string(results.ToArray());

            return finalOutput;

        }
    }
}

