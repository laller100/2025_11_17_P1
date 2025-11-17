using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_11_17_P1
{
    internal class Program
    {
        static void Main()
        {
            double a = ReadDouble("adja meg az a értékét: ");
            double b = ReadDouble("adja meg az b értékét: ");
            double c = ReadDouble("adja meg az c értékét: ");

            double D = b * b - 4 * a * c; // diszkrimináns

            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"Két valós megoldás: x1 = {x1}, x2 = {x2}");
            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Egy valós megoldás: x = {x}");
            }
            else
            {
                double real = -b / (2 * a);
                double imag = Math.Sqrt(-D) / (2 * a);
                Console.WriteLine($"Komplex megoldások: x1 = {real} + {imag}i, x2 = {real} - {imag}i");
            }
        }

        static double ReadDouble(string name)
        {
            while (true)
            {
                Console.Write($"{name} = ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out double value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Hiba: számot adj meg!");
                }
            }
        }
    }
}
