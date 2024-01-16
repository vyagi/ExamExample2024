using System;
using System.Collections.Generic;

namespace Geometry
{
    public class PolygonalChain : Segment, IMoveable
    {
        private List<Point> _midpoints = new List<Point>();

        public PolygonalChain(Point start, Point end) : base(start,end) { }
        
        public void AddMidpoint(Point midpoint) => _midpoints.Add(midpoint);

        public void Move(double x, double y)
        {
            _start.Move(x, y);
            _end.Move(x, y);

            foreach (var midpoint in _midpoints)
                midpoint.Move(x, y);
        }

        public override double Length
        {
            get
            {
                var allPoints = new List<Point>();
                allPoints.Add(_start);
                allPoints.AddRange(_midpoints);
                allPoints.Add(_end);

                var totalLength = 0.0;
                for (int i = 0; i < allPoints.Count - 1; i++)
                {
                    var segment = new Segment(allPoints[i], allPoints[i + 1]);
                    totalLength += segment.Length;
                }

                return totalLength;
            }
        }
    }

    public class Segment
    {
        protected Point _start;
        protected Point _end;

        public Segment(Point start, Point end)
        {
            _start = start;
            _end = end;
        }

        public virtual double Length =>
            Math.Sqrt(Math.Pow(_start.X - _end.X, 2) 
                + Math.Pow(_start.Y - _end.Y, 2));
    }

    public class Point : IMoveable
    {
        private double _x;
        private double _y;

        public double X => _x;
        public double Y => _y;

        public Point() { }
        public Point(double v) => _x = _y = v;
        public Point(double x, double y) 
        {
            _x = x;
            _y = y;
        }

        public void Move(double x, double y)
        {
            _x += x;
            _y += y;
        }

        public virtual double Distance() => Math.Sqrt(X * X + Y * Y);

        public override string ToString() => $"({X},{Y})";
    }
}
