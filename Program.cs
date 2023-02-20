using System;

namespace PrivateMultipleObjects
{
    class Club
    {
        private string name;
        private int foundationYear;
        private string country;

        public Club()
        {
            this.name = "";
            this.foundationYear = 0;
            this.country = "";
        }

        public Club(string name, int foundationYear, string country)
        {
            this.name = name;
            this.foundationYear = foundationYear;
            this.country = country;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetFoundationYear()
        {
            return this.foundationYear;
        }

        public void SetFoundationYear(int year)
        {
            this.foundationYear = year;
        }

        public string GetCountry()
        {
            return this.country;
        }

        public void SetCountry(string country)
        {
            this.country = country;
        }

        public virtual void Add()
        {
            Console.WriteLine("Adding a new Club...");
        }

        public virtual void Change()
        {
            Console.WriteLine("Changing an existing Club...");
        }

        public virtual void Display()
        {
            Console.WriteLine("Displaying a Club...");
        }
    }

    class NerdClub : Club
    {
        private string topic;
        private int memberCount;

        public NerdClub()
        {
            this.topic = "";
            this.memberCount = 0;
        }

        public NerdClub(string name, int foundationYear, string country, string topic, int memberCount)
            : base(name, foundationYear, country)
        {
            this.topic = topic;
            this.memberCount = memberCount;
        }

        public string GetTopic()
        {
            return this.topic;
        }

        public void SetTopic(string topic)
        {
            this.topic = topic;
        }

        public int GetMemberCount()
        {
            return this.memberCount;
        }

        public void SetMemberCount(int count)
        {
            this.memberCount = count;
        }

        public override void Add()
        {
            base.Add();
            Console.WriteLine("Adding a new Nerd Club...");
        }

        public override void Change()
        {
            base.Change();
            Console.WriteLine("Changing an existing Nerd Club...");
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Displaying a Nerd Club...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Club[] clubs = new Club[2];
            clubs[0] = new Club("Football Club", 1890, "England");
            clubs[1] = new NerdClub("Computer Club", 1995, "USA", "Programming", 20);

            Console.WriteLine("Base class:");
            clubs[0].Display();
            clubs[0].Add();
            clubs[0].Change();

            Console.WriteLine("\nDerived class:");
            clubs[1].Display();
            clubs[1].Add();
            clubs[1].Change();
        }
    }
}
