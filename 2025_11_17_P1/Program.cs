using System;

namespace _2025_11_17_P1
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                double a = ReadDouble("adja meg az a értékét");
                double b = ReadDouble("adja meg az b értékét");
                double c = ReadDouble("adja meg az c értékét");

                double D = b * b - 4 * a * c; 

                if (D < 0)
                {
                    Console.WriteLine("Hiba: gyök alatt nem lehet negatív szám! Próbáld újra.\n");
                    continue; 
                }

                if (D > 0)
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine($"Két valós megoldás: x1 = {x1}, x2 = {x2}");
                }
                else 
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"Egy valós megoldás: x = {x}");
                }

                break; 
            }
        }

        static double ReadDouble(string name)
        {
            while (true)
            {
                Console.Write($"{name} = ");
                string input = Console.ReadLine();

                try
                {
                    double value = Convert.ToDouble(input);

                    if (value < 0)
                    {
                        Console.WriteLine("Hiba: a szám nem lehet negatív! Próbáld újra.");
                    }
                    else if (value == 0)
                    {
                        Console.WriteLine("Hiba: nulla nem lehet benne! Próbáld újra.");
                    }
                    else
                    {
                        return value;
                    }
                }
                catch
                {
                    Console.WriteLine("Hiba: érvénytelen szám! Próbáld újra.");
                }
            }
        }
    }
}
