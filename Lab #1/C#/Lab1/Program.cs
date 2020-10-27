using System;

namespace Lab2
{
    class Triangle
    {
        double[] sides = new double[3];
        double[] angles = new double[3];

        public Triangle(double AX, double AY, double BX, double BY, double CX, double CY)
        {
            calcSides(AX, AY, BX, BY, CX, CY);
            calcAngles();
        }

        void calcSides(double AX, double AY, double BX, double BY, double CX, double CY)
        {
            sides[0] = Math.Sqrt(Math.Pow(BX - AX, 2) + Math.Pow((BY - AY), 2));
            sides[1] = Math.Sqrt(Math.Pow(CX - BX, 2) + Math.Pow((CY - BY), 2));
            sides[2] = Math.Sqrt(Math.Pow(CX - AX, 2) + Math.Pow((CY - AY), 2));
        }

        void calcAngles()
        {
            angles[0] = toDegrees(Math.Acos((Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2) - Math.Pow(sides[0], 2)) / (2 * sides[1] * sides[2])));
            angles[1] = toDegrees(Math.Acos((Math.Pow(sides[0], 2) + Math.Pow(sides[2], 2) - Math.Pow(sides[1], 2)) / (2 * sides[0] * sides[2])));
            angles[2] = toDegrees(Math.Acos((Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) / (2 * sides[0] * sides[1])));
        }

        double toDegrees(double value)
        {
            return value * (180 / Math.PI);
        }

        public double[] getSidesValues { get { return sides; } }
        public double[] getAngles { get { return angles; } }
    }

    class Program
    {
        public static Triangle tr = new Triangle(0, 3, -2, 0, 0, -3);

        static void Main(string[] args)
        {
            Console.WriteLine($"Трикутник ABC має довжини сторон : {tr.getSidesValues[0]} {tr.getSidesValues[1]} {tr.getSidesValues[2]}\n" +
                $"Та має кути : {tr.getAngles[0]} {tr.getAngles[1]} {tr.getAngles[2]}");

            Console.ReadLine();
        }
    }
}
