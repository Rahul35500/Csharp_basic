using System;

namespace TypesSecondProgram
{
    class First
    {
        public string Title;
        public string Author;
        public void display()
        {
            System.Console.WriteLine($"title-{Title}\nAuthor-{Author}");
        }

    }
    class Seccond:First
    {
        public Seccond(string tit,string auth)
        {
            Title=tit;
            Author=auth;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Seccond obj=new Seccond("Csharp Book","Scott haslman");
            obj.display();
        }
    }
}
