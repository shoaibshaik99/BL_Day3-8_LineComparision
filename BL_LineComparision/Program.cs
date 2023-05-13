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
            // A method to calculate the distance between two points
            // Get the coordinates of the two end points from the user
            Console.WriteLine("Enter the coordinates of the first point (x1, y1):");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the second point (x2, y2):");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            // Call the Distance method to find the length of the line segment
            double length = Distance(x1, y1, x2, y2);

            // Display the result
            Console.WriteLine("The length of the line segment is {0}", length);
        }
    }

}