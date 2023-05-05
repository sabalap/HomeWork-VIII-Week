using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_VIII_Week.TaskN3
{
    internal abstract class Animal
    {
        public string Name { get; set; }

        public void SetName()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Name = name;
        }
        public void GetName()
        {
            Console.WriteLine($"dog's name is {Name}");
        }
        public abstract void Eat();
    }
}
