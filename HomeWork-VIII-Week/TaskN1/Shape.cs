using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_VIII_Week.TaskN1
{
    internal class Shape
    {
        public int height;
        public int width;

        public Shape(int height, int width)
        {
            this.height = height;
            this.width = width;
        }
        public virtual void CalculateArea()
        {
            Console.WriteLine("Calculate Area");
            Console.WriteLine(height * width);
        }
    }
}
