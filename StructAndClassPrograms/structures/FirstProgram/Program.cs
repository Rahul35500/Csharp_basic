using System;

namespace FirstProgram
{
    struct sample
    {
        public int x;
        public int y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            sample obj=new sample();
            obj.x=12;
            obj.y=21;
            System.Console.WriteLine(obj.x+obj.y);
        }
    }
}
