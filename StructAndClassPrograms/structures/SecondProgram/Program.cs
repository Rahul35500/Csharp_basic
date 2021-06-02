using System;

namespace SecondProgram
{
    class Program
    {
        
        struct employeeInformation
        {
            public string name;
            public DateBirth date;
        }
        struct DateBirth
        {
            public int day;
            public int Month;
            public int year;

        }
        static void Main(string[] args)
        {
            int totalValue=2;
            employeeInformation[] obj=new employeeInformation[3];
            for(int i=0;i<totalValue;i++)
            {
                System.Console.WriteLine("Enter the information of employee");
                System.Console.WriteLine("Enter the name of the employee");
                obj[i].name=Console.ReadLine();
                System.Console.WriteLine("Enter the day of the birth");
                obj[i].date.day=int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter the month of the birth");
                // obj[i].date.Month=int.Parse(Console.ReadLine());
                int.TryParse(Console.ReadLine(),out obj[i].date.Month);
                System.Console.WriteLine("Enter the year of the birth");
                int.TryParse(Console.ReadLine(),out obj[i].date.year);
            }

        for(int i=0;i<totalValue;i++)
        {
            System.Console.WriteLine($"Inforamtion of {i+1} employee is");
            System.Console.WriteLine($"name={obj[i].name}\nday={obj[i].date.day}\nmonth={obj[i].date.Month}\nyear={obj[i].date.year}");
        }
        }
    }
}
