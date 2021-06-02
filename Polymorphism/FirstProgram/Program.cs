using System;

namespace FirstProgram
{
   public class FirstClass
    {
        public int FirstNumber;
        public int SecondNumber;

        public virtual int GetData(int first,int second)
        {
            FirstNumber=first;
            SecondNumber=second;
            
            return FirstNumber+SecondNumber;
        }
        public void Display()
        {
            System.Console.WriteLine($"FirstNumber={FirstNumber}\nSecondNumber={SecondNumber}");
        }
    }
   public class SecondClass:FirstClass
    {
        public override int GetData(int first,int second)
        {
            FirstNumber=first;
            SecondNumber=second;

            return (FirstNumber-SecondNumber);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FirstClass obj=new FirstClass();
            FirstClass objSecondTest=new SecondClass();
            System.Console.WriteLine(objSecondTest.GetData(23,12));
            objSecondTest.Display();
            System.Console.WriteLine(obj.GetData(23,1));
            obj.Display();
        }
    }
}
