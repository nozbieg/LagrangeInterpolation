using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagrangeInterpolation
{
    public readonly struct InterpolationNode(double X, double Y)
    {
        public double X { get; } = X;
        public double Y { get; } = Y;
    }
    public static class Lagrange
    {


        public static double LagrangeInterpolation(InterpolationNode[] nodes, double xp)
        {
            int n = nodes.Length;
            double result = 0.0;

            for (int i = 0; i < n; i++)
            {
                double term = nodes[i].Y;
                for (int j = 0; j < n; j++)
                {
                    if (j != i)
                    {
                        term *= (xp - nodes[j].X) / (nodes[i].X - nodes[j].X);
                    }
                }
                result += term;
            }
            Console.WriteLine($"W({xp}) = {result}");
            return result;
        }


        public static InterpolationNode[] GenerateRandomNodes(int numberOfNodes, double minNumber, double maxNumber)
        {
            var r = new Random();
            InterpolationNode[] interpolationNodes = new InterpolationNode[numberOfNodes];
            for (int i = 0; i < numberOfNodes; i++)
            {
                var x = Math.Round(minNumber + (r.NextDouble() *(maxNumber - minNumber)), 2);
                var y = Math.Round(minNumber + (r.NextDouble() *(maxNumber - minNumber)), 2);
                var node = new InterpolationNode(x, y);
                interpolationNodes[i] = node;
                Console.WriteLine($"Point: X:{node.X} | Y:{node.Y}");
            }
            return interpolationNodes;
        }
    }
}
