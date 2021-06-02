using System;

namespace FirstProgram
{
    class Program
    {
        static int AddFunction(int a,int b)
        {
            return a+b;
        }
        static int AddFunction(int a,int b,int c)
        {
            return a+b+c;
        }
        static double AddFunction(double a,int b)
        {
            return a+b;
        }
        static decimal AddFunction(decimal a,decimal b)
        {
            return a+b;
        }

        
        
        
        
        static void Main(string[] args)
        {
            System.Console.WriteLine("Example of method overloading");
            System.Console.WriteLine($"Additon of two integer number {AddFunction(1,2)}");
            System.Console.WriteLine($"Additon of three integer number {AddFunction(1,2,5)}");
            System.Console.WriteLine($"Additon of decimal {AddFunction(1.2m,1)}");
            System.Console.WriteLine($"Additon of double {AddFunction(55.55m,12.2m)}");
        }
    }
}
