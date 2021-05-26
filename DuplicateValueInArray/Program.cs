using System;
using System.Collections.Generic;

namespace DuplicateValueInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5,5,5, 6, 7, 8, 9, 11, 12, 12,12,12,2,10,1,1,3};
            duplicate(array);

        }
        static void duplicate(int[] array)
        {
            int count=0;
            Dictionary<int,int> dictionaryName=new Dictionary<int, int>();
            for(int i=0;i<array.Length;i++)
            {
                if(dictionaryName.ContainsKey(array[i]))
                {
                    count++;
                    dictionaryName[array[i]]=count;

                }
                else
                {
                    count=0;
                    dictionaryName[array[i]]=count;
                }
            }
            foreach(var item in dictionaryName)
            {
                if(item.Value>0)
                {
                    System.Console.WriteLine($"Duplicate value {item.Key} is occurred {item.Value} times");
                }
            }
        }
    }
}
