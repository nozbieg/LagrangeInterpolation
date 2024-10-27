
using LagrangeInterpolation;

PritnStudentInfo();

InterpolationNode[] points = [
            new(1.0, 2.0),
            new(2.0, 3.0),
            new(3.0, 5.0),
            new(4.0, 8.0),
            new(5.0, 13.0),
            new(6.0, 21.0),
            new(7.0, 34.0),
            new(8.0, 51.0),
            new(9.0, 85.0),
            new(10.0, 136.0)
        ];

InterpolationNode[] points3 = [
            new(0, 4),
            new(1, 2),
            new(2.5, 2.75)
        ];

var randomPoints = Lagrange.GenerateRandomNodes(25, 1, 255.5);

var xp = 2.5; 

_ = Lagrange.LagrangeInterpolation(points, xp);

_ = Lagrange.LagrangeInterpolation(points3, xp); 

_ = Lagrange.LagrangeInterpolation(randomPoints, xp);

FinishProgram();


static void FinishProgram()
{
    Console.WriteLine();
    Console.WriteLine("===");
    Console.WriteLine("Program completed.");
    Console.WriteLine("Press Enter to close.");
    Console.WriteLine("===");
    Console.ReadLine();
    Environment.Exit(0);
}

static void PritnStudentInfo()
{
    Console.WriteLine("=== ===");
    Console.WriteLine("=== Lagrange Interpolation ===");
    Console.WriteLine("=== Norbert Olesiak-Zbieg ===");
    Console.WriteLine("=== Informatyka II Stopnia ===");
    Console.WriteLine("=== nr albumu 41237 ===");
    Console.WriteLine("=== ===");
    Console.WriteLine();
}

