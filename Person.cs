using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    internal class Person
    {
        public in Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void SayName()
        {
            Console.WriteLine($"My name is {Name}");
        }

        public void Info()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age} y.o.");
        }

        public void Run()
        {
            Console.WriteLine($"{Id}.{Name} is running!");
        }



    }
}
