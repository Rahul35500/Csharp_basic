using System;
using System.Collections.Generic;

namespace CommonElementBetweenTwoAray
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = new string[] { "Article", "for", "Geeks", "for", "Geeks" };
            var secondArray = new string[] { "Article", "Geeks", "Geeks", "for" };
            Dictionary<string, int> DictinaryName = new Dictionary<string, int>();
            string[] sample = new string[firstArray.Length];
            int i, j, k = 0;

            for (i = 0; i < firstArray.GetLength(0); i++)
            {
                for (j = 0; j < secondArray.GetLength(0); j++)
                {
                    if (firstArray[i] == secondArray[j])
                    {
                        DictinaryName[firstArray[i]] = k;
                        k++;
                    }
                }
            }
            System.Console.WriteLine("Common Elements Between Two Array:");
            foreach (var best in DictinaryName)
            {
                System.Console.WriteLine($"{best.Key}");
            }



        }
    }
}
