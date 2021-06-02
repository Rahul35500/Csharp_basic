using System;

namespace FirstProgram
{
    class work
    {
        public int Id;
        public string Title;
        public string Description;
        public TimeSpan JobLength;

        private static int CurrentId;

        public work()
        {
            Id = 0;
            Title = "Default";
            Description = "default";
            JobLength = new TimeSpan();
        }
        public work(string tit, string des, TimeSpan joblen)
        {
            Title = tit;
            Description = des;
            JobLength = joblen;
            Id = GetNextID();

        }
        static work() => CurrentId = 4;
        public int GetNextID() => ++CurrentId;
        public void Update(string title, TimeSpan joblen)
        {
            Title = title;
            JobLength = joblen;
        }
        public override string ToString()
        {
            return $"{Id}-{Title}-{JobLength}";
        }

    }
    class ChangeRequest : work

    {
        protected int originalItemID { get; set; }

      //  public ChangeRequest() { }

        public ChangeRequest(string title, string desc, TimeSpan jobLen, int originalID)
        {
            Id = GetNextID();
            Title = title;
            Description = desc;
            JobLength = jobLen;

            originalItemID = originalID;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            work objWork=new work("diary","Constructor of base class",new TimeSpan(5,20,22));

            System.Console.WriteLine(objWork.ToString());
            
            ChangeRequest objChangeRequest=new ChangeRequest("story","constuctor of the dervied class",new TimeSpan(3,12,45),1);

           System.Console.WriteLine(objChangeRequest.ToString());

           objChangeRequest.Update("funnyBook",new TimeSpan(1,3,4));
           System.Console.WriteLine(objChangeRequest.ToString());




        }
    }
}