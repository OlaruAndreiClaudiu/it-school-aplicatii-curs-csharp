using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace App17
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Square shape1 = new Square(3);
            Rectangle shape2 = new Rectangle(2,3);
            Console.WriteLine(shape1.GetArea());
            Console.WriteLine(shape1.GetPerimeter());
        }
    }
    abstract class Shape()
    {
        public abstract float GetArea();
        public abstract float GetPerimeter();
    }
    class Square : Shape
    {
        float Latura;
        public Square(float latura)
        {
            Latura = latura;
        }
        public override float GetArea()
        {
            return Latura * Latura;
        }
        public override float GetPerimeter()
        {
            return 4 * Latura;
        }
    }
    class Rectangle : Shape
    {
        float Lungime;
        float Latime;
        public Rectangle(float lungime, float latime)
        {
            Lungime = lungime;
            Latime = latime;
        }
        public override float GetArea()
        {
            return Lungime * Latime;
        }
        public override float GetPerimeter()
        {
            return 2*(Lungime + Latime);
        }
    }
}
