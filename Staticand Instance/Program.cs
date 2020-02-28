using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staticand_Instance
{
    class Circle
    {
        float PI = 3.141F;
        int Radius;
        public Circle(int radius)
        {
            this.Radius = radius;
        }
        public float CalculateArea()
        {
            return this.PI * this.Radius * this.Radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle C1 = new Circle(5);
            float Area = C1.CalculateArea();
            Console.WriteLine("Area = {0}", Area);
            Console.ReadLine();
        }
        
    }
}
