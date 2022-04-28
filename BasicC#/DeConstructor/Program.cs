using System;

namespace DeConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "Mert",
                Age = 26
            };

            var (x, y) = person;
            Console.WriteLine(x);
            Console.WriteLine(y);


        }
    }
    class Person
    {


        public string Name { get; set; }

        public int Age { get; set; }

        public void Deconstruct(out string name, out int age)
        {
            name = Name;
            age = Age;

        }
        
    }
} 
