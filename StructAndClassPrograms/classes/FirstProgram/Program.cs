using System;

namespace FirstProgram
{
    class Program
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
                obj[i].titleName = Console.ReadLine();
                Console.WriteLine("Enter the name of the author");
                obj[i].Author = Console.ReadLine();
            }
            for (int i = 0; i < total; i++)
            {
                System.Console.WriteLine($"Inforamtion of {i + 1} book");
                System.Console.WriteLine($"name={obj[i].titleName}\nAuthor name={obj[i].Author}");

            }

        }
    }
}
