using Geometry;
using System;

namespace GeometryTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point();
            Console.WriteLine($"{point.X}, {point.Y}");

            var point1 = new Point(5);
            Console.WriteLine($"{point1.X}, {point1.Y}");

            var point2 = new Point(3.5, -2.5);
            Console.WriteLine($"{point2.X}, {point2.Y}");

            point.Move(1, 2);
            Console.WriteLine($"{point.X}, {point.Y}");

            var segment = new Segment(point2, new Point(6, 7));

            Console.WriteLine(new Point(3,4).Distance());

            var pc = new PolygonalChain(new Point(1, 1), new Point(2, 2));
            pc.AddMidpoint(new Point(1, 2));

            Console.WriteLine(pc.Length);
            Console.WriteLine(pc);
            Console.WriteLine(point);
        }
    }
}
