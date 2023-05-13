namespace BL_LineComparision
{
    internal class Program
    {
        static double Distance(double x1, double y1, double x2, double y2)
        {
            // Use the Pythagorean theorem to find the length of the hypotenuse
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            // Get the coordinates of the four points from the user
            Console.WriteLine("Enter the coordinates of the first point of the first line segment (x1, y1):");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the second point of the first line segment (x2, y2):");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the first point of the second line segment (x3, y3):");
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the second point of the second line segment (x4, y4):");
            double x4 = Convert.ToDouble(Console.ReadLine());
            double y4 = Convert.ToDouble(Console.ReadLine());

            // Call the Distance method to find the lengths of the two line segments
            double length1 = Distance(x1, y1, x2, y2);
            double length2 = Distance(x3, y3, x4, y4);

            // Compare the lengths and display the result
            if (length1 == length2)
            {
                Console.WriteLine("The two line segments have the same length.");
            }
            else
            {
                Console.WriteLine("The two line segments do not have the same length.");
            }
        }
    }
}