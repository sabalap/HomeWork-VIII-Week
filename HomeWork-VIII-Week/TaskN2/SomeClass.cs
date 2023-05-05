using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_VIII_Week.TaskN2
{
    internal class SomeClass : IFirst, ISecond
    {
        public void firstMethod()
        {
            Console.WriteLine("First Method");
        }
        public void secondMethod()
        {
            Console.WriteLine("Second Method");
        }
    }
}
