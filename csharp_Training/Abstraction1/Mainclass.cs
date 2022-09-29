using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction1
{
    public class Mainclass
    {
        static void main()
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
