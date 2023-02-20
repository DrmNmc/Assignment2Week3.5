using System;

namespace SimpleInheritance
{
    class Animal
    {
        public string name;

        public Animal()
        {
            name = "";
        }

        public Animal(string name)
        {
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }
    }

    class Cat : Animal
    {
        public int age;
        public string color;
        public string breed;

        public Cat()
        {
            age = 0;
            color = "";
            breed = "";
        }

        public Cat(string name, int age, string color, string breed)
            : base(name)
        {
            this.age = age;
            this.color = color;
            this.breed = breed;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"I am a {breed} cat, my name is {name}, I am {age} years old, and I am {color}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat();
            myCat.name = "Socks";
            myCat.age = 2;
            myCat.color = "black and white";
            myCat.breed = "Siamese";

            myCat.DisplayDetails();

            Cat myOtherCat = new Cat("Mittens", 5, "gray", "Persian");
            myOtherCat.DisplayDetails();
        }
    }
}
