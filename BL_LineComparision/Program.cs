namespace BL_LineComparision
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    class Line
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public double Length()
        {
            return Math.Sqrt(Math.Pow(End.X - Start.X, 2) + Math.Pow(End.Y - Start.Y, 2));
        }

        public int CompareTo(Line other)
        {
            if (Length() < other.Length())
                return -1;
            else if (Length() == other.Length())
                return 0;
            else
                return 1;
        }

        public bool Equals(Line other)
        {
            return Length() == other.Length();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the coordinates of the first point of line 1 (x y):");
            string[] input1 = Console.ReadLine().Split();
            double x1 = double.Parse(input1[0]);
            double y1 = double.Parse(input1[1]);
            Point p1 = new Point(x1, y1);

            Console.WriteLine("Enter the coordinates of the second point of line 1 (x y):");
            string[] input2 = Console.ReadLine().Split();
            double x2 = double.Parse(input2[0]);
            double y2 = double.Parse(input2[1]);
            Point p2 = new Point(x2, y2);
            Line line1 = new Line(p1, p2);

            Console.WriteLine("Enter the coordinates of the first point of line 2 (x y):");
            string[] input3 = Console.ReadLine().Split();
            double x3 = double.Parse(input3[0]);
            double y3 = double.Parse(input3[1]);
            Point p3 = new Point(x3, y3);

            Console.WriteLine("Enter the coordinates of the second point of line 2 (x y):");
            string[] input4 = Console.ReadLine().Split();
            double x4 = double.Parse(input4[0]);
            double y4 = double.Parse(input4[1]);
            Point p4 = new Point(x4, y4);
            Line line2 = new Line(p3, p4);

            int result = line1.CompareTo(line2);
            if (result < 0)
                Console.WriteLine("Line 1 is shorter than Line 2.");
            else if (result == 0)
                Console.WriteLine("Line 1 is equal in length to Line 2.");
            else
                Console.WriteLine("Line 1 is longer than Line 2.");

            /*
            bool equal = line1.Equals(line2);
            if (equal)
                Console.WriteLine("Line 1 is equal in length to Line 2.");
            else
                Console.WriteLine("Line 1 is not equal in length to Line 2.");
            */
        }
    }
}
