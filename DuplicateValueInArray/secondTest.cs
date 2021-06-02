using System;
using System.Collections.Generic;

namespace DuplicateValueInArray
{
    class countinfo
    {
        public int count;
        public countinfo()
        {
        count=0;
        }
        public void increment()
        {
            count++;
        }
    }
    class Program
    {
         public static Dictionary<int,countinfo> dictionaryName=new Dictionary<int, countinfo>();

        static void Main(string[] args)
        {
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5,5,5, 6, 7, 8, 9, 11, 12, 12,12,12,2,10,1,1,3};
            duplicate(array);

        }
        static void duplicate(int[] array)
        {
            // int count=0;
            for(int i=0;i<array.Length;i++)
            {
                if(dictionaryName.ContainsKey(array[i]))
                {
                    dictionaryName[array[i]].increment();

                }
                else
                {
                    dictionaryName[array[i]]=new countinfo();
                }
            }
            foreach(var item in dictionaryName)
            {
                if(item.Value.count>0)
                {
                    System.Console.WriteLine($"Duplicate value {item.Key} is occurred {item.Value.count} times");
                }
            }
        }
    }
}
