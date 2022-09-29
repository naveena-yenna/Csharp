
using System;

namespace Abstraction1
{
    public abstract class Figure
    {
        public double width, heigth, radius;
        public const float pi = 3.14f;
        public abstract double GetArea();
       
    }
    public class Rectangle : Figure
    {
        public Rectangle(double width, double heigth)
        {
            this.width = width;
            this.heigth = heigth;
        }
        public override double GetArea()
        {
            return width * heigth;
        }
    } 
    
    public class Circle : Figure
    {
 public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return pi * radius * radius;
        }
    }
    public class cone : Figure
    {
        public cone(double radius,double heigth)
        {
            this.radius = radius;
            this.heigth = heigth;
        }
        public override double GetArea()
        {
            return pi * radius * radius;
        }
    }
    public class Mainclass1
    {
       public static void main(String[] args)
        {
            Rectangle r = new Rectangle(12.8, 89.0);
            Circle c = new Circle(67.9);
            cone c1 = new cone(67.9, 90.0);
            Console.WriteLine(r.GetArea());
            Console.WriteLine(r.GetArea());
            Console.WriteLine(r.GetArea());
        }
    }
}
    

