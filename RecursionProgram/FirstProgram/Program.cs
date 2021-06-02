using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Print all natual number");
           PrintValue(1,10);
        }
        public static int PrintValue(int numbers,int times)
        {
            if(times<1)
            {
                return numbers;
            }
            times--;
            System.Console.WriteLine(numbers);
            return PrintValue(numbers+1,times);
        }
    }
}
