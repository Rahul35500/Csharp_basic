using System;
using System.Linq;
 
 
 
public static class Extensions
{
    public static bool findd<T>(this T[] arwray, T target) {
        return arwray.Contains(target);
    }
}
 
 
 
public class Example
{
    public static void Main()
    {
        int[] arrady = { 1, 2, 3, 4, 5 };
        int target = 4;
 
        bool isExist = arrady.findd(target);
        if (isExist) {
            Console.WriteLine("Element found in the array");
        }
        else {
            Console.WriteLine("Element not found in the given array");
        }
    }
}
