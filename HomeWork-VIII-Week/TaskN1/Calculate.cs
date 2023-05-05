using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_VIII_Week.TaskN1
{
    internal class Calculate : Area
    {
        public Calculate(int height, int width) : base(height, width)
        {
        }

        public override void CalculateArea()
        {
            base.CalculateArea();
        }

        public void Perimeter()
        {
            Console.WriteLine("Calculate Perimeter");
            Console.WriteLine(height * 2 + width * 2);
        }
    }
}
