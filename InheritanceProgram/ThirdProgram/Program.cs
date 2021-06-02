using System;

namespace ThirdProgram
{
    interface IFirst
    {
        public void GetData(string tit,string auth);
    }
    interface ISecond
    {
        void Display();
    }

    class MainClass : IFirst, ISecond
    {
        public string Title;
        public string Author;
        public void GetData(string tit,string auth)
        {
            Title=tit;
            Author=auth;
        }
        public void Display()
        {
            System.Console.WriteLine($"Title-{Title}\nAuthor-{Author}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MainClass obj=new MainClass();
            obj.GetData("csharp Book","Scott haslman");
            obj.Display();
        }
    }
}
