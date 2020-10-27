using System;

namespace Lab2
{
    class Program
    {
        public static double[] getSidesValues(double AX, double AY, double BX, double BY, double CX, double CY)
        {
            double[] buff = new double[3];

            buff[0] = Math.Sqrt(Math.Pow(BX - AX, 2) + Math.Pow((BY - AY), 2));
            buff[1] = Math.Sqrt(Math.Pow(CX - BX, 2) + Math.Pow((CY - BY), 2));
            buff[2] = Math.Sqrt(Math.Pow(CX - AX, 2) + Math.Pow((CY - AY), 2));

            return buff;
        }

        public static string getTriangleType(double[] Sides)
        {
            if (Sides[0] == Sides[1] && Sides[1] == Sides[2] && Sides[0] == Sides[2]) { return "Рівносторонній"; }
            else if (Sides[0] == Sides[1] || Sides[1] == Sides[2] || Sides[0] == Sides[2]) { return "Рівнобедрений"; }
            return "Різносторонній";
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Трикутник ABC: {getTriangleType(getSidesValues(0, 3, -2, 0, 0, -3))}");
            Console.ReadLine();
        }
    }
}
