using System;

namespace ReverseCaseOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            string test=ReverseString("ReVerSeSTriNG");
            System.Console.WriteLine(test);
            System.Console.WriteLine(ReverseString("heLLaAw wold"));
        }
        static string ReverseString(string name)
        {
            char[] ReverseCharacter=new char[name.Length];
            for(int i=0;i<name.Length;i++)
            {
                if(name[i]>=65 && name[i]<=90)
                {
                    ReverseCharacter[i]=(char)(name[i]+32);
                }
                else if(name[i]>=97 && name[i]<=122)
                {
                    ReverseCharacter[i]=(char)(name[i]-32);
                }
                else
                {
                    ReverseCharacter[i]=name[i];
                }
            }
            string name1=new string(ReverseCharacter);
            return name1;

        }
    }
}
