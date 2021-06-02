using System;

namespace ThirdProgram
{
    public struct book
    {
        public void Display()
        {
            System.Console.WriteLine("InForamation of booke");
        }
        public string tittle;
        public string Author;

    }
    public class Program
    {
        static void Main(string[] args)
        {
            int total = 2;
            book[] obj = new book[total];
            obj[0].Display();
            for (int i = 0; i < total; i++)
            {
                System.Console.WriteLine($"Enter the Information of  {i + 1} book ");
                Console.WriteLine("Enter the name of the book");
                obj[i].tittle = Console.ReadLine();
                Console.WriteLine("Enter the name of the author");
                obj[i].Author = Console.ReadLine();
            }
            for (int i = 0; i < total; i++)
            {
                System.Console.WriteLine($"Inforamtion of {i + 1} book");
                System.Console.WriteLine($"name={obj[i].tittle}\nAuthor name={obj[i].Author}");

            }
        }
    }
}
