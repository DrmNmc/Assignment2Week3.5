using System;

namespace AnimalInheritance
{
    class Animal
    {
        private string name;
        protected string type;
        public string color;

        public void SetName(string name)
        {
            this.name = name;
        }

        public virtual string GetName()
        {
            return this.name;
        }

        public void SetType(string type)
        {
            this.type = type;
        }

        public virtual string GetType()
        {
            return this.type;
        }
    }

    class Bird : Animal
    {
        private bool canFly;
        protected int wingspan;
        public string habitat;

        public void SetCanFly(bool canFly)
        {
            this.canFly = canFly;
        }

        public bool GetCanFly()
        {
            return this.canFly;
        }

        public void SetWingspan(int wingspan)
        {
            this.wingspan = wingspan;
        }

        public int GetWingspan()
        {
            return this.wingspan;
        }

        public override string GetName()
        {
            return "The " + base.GetType() + " bird named " + base.GetName();
        }

        public override string GetType()
        {
            return "Bird";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            myAnimal.SetName("Leo");
            myAnimal.SetType("Lion");
            myAnimal.color = "golden";
            Console.WriteLine($"My animal is a {myAnimal.GetType()} named {myAnimal.GetName()} and is {myAnimal.color} in color.");

            Bird myBird = new Bird();
            myBird.SetName("Eagle");
            myBird.SetType("Bald");
            myBird.color = "brown";
            myBird.SetCanFly(true);
            myBird.SetWingspan(6);
            myBird.habitat = "mountains";
            Console.WriteLine($"My bird is a {myBird.GetType()} named {myBird.GetName()}, has a wingspan of {myBird.GetWingspan()} feet, and lives in {myBird.habitat}.");
        }
    }
}
