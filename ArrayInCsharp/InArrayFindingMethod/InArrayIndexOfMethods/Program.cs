using System;

namespace InArrayIndexOfMethods
{
    class Program
    {
    //     static void Main(string[] args)
    //     {
    //        int[] arrayData={1,2,3,5,6,7};
    //        int Result=Array.IndexOf(arrayData,2);
    //        if(Result!=-1)
    //        {
    //            System.Console.WriteLine("Result found");
    //        }
    //        else
    //        {
    //            System.Console.WriteLine("Result not found");
    //        }

    //     }
         static void Main(string[] args)
         {
            int[] arrayData={1,3,5,4,6,3,7,8,9,0};
             var result=Array.FindIndex(arrayData,2,8,ele=>ele <1);
             System.Console.WriteLine(result);

         }
    }
}
