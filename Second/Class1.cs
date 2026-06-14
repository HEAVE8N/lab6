using System;

namespace PracticeC_
{
    internal class LineSegment
    {
        private double x1;
        private double y1;
        private double x2;
        private double y2;

        public LineSegment()
        {
            x1 = 0;
            y1 = 0;
            x2 = 1;
            y2 = 1;
        }

        public LineSegment(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public LineSegment(LineSegment other)
        {
            this.x1 = other.x1;
            this.y1 = other.y1;
            this.x2 = other.x2;
            this.y2 = other.y2;
        }

        public double X1
        {
            get { return x1; }
            set { x1 = value; }
        }

        public double Y1
        {
            get { return y1; }
            set { y1 = value; }
        }

        public double X2
        {
            get { return x2; }
            set { x2 = value; }
        }

        public double Y2
        {
            get { return y2; }
            set { y2 = value; }
        }

        public bool Contains(double value)
        {
            double minX = Math.Min(x1, x2);
            double maxX = Math.Max(x1, x2);
            return value >= minX && value <= maxX;
        }

        public static double operator !(LineSegment segment)
        {
            double dx = segment.x2 - segment.x1;
            double dy = segment.y2 - segment.y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public static LineSegment operator ++(LineSegment segment)
        {
            return new LineSegment(segment.x1 + 1, segment.y1 + 1,
                                   segment.x2 + 1, segment.y2 + 1);
        }

        public static explicit operator int(LineSegment segment)
        {
            return (int)segment.x1;
        }

        public static implicit operator double(LineSegment segment)
        {
            return segment.y1;
        }

        public static LineSegment operator +(LineSegment segment, int d)
        {
            return new LineSegment(segment.x1 + d, segment.y1 + d,
                                   segment.x2 + d, segment.y2 + d);
        }

        public static LineSegment operator +(int d, LineSegment segment)
        {
            return new LineSegment(segment.x1 + d, segment.y1 + d,
                                   segment.x2 + d, segment.y2 + d);
        }

        public static bool operator <(LineSegment segment, int value)
        {
            return segment.Contains(value);
        }

        public static bool operator >(LineSegment segment, int value)
        {
            return segment.Contains(value);
        }

        public override string ToString()
        {
            return $"({x1:F2}, {y1:F2}) -> ({x2:F2}, {y2:F2})";
        }
    }
}