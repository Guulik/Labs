using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static int ReadInt()
        {
            return Convert.ToInt32(ReadLine());
        }
        static float ReadFloat()
        {
            return float.Parse(ReadLine());
        }
        static void first_task()
        {
            WriteLine("Please enter angle in degrees: ");
           float alpha = ReadFloat();
            WriteLine($"Angle in radians = pi* {alpha / 180}");
        }
        static void second_task()
        {
            WriteLine("Please enter k for angle in format: k*pi");
            float k = ReadFloat();
            WriteLine($"Angle in degrees: {k * 180}* pi");
        }
        static void third_task()
        {
            WriteLine("Please enter X(kgs), A(rubles),Y(kgs)");
            int X = ReadInt(), A = ReadInt(), Y = ReadInt();
            WriteLine($"1 kg costs: {A / X}, {Y} kgs costs: {A / X * Y}");
        }
        static void fourth_task()
        {
            WriteLine("Please enter V1(km/h), V2(km/h), S(km), T(h)");
            int V1 = ReadInt(), V2 = ReadInt(), S = ReadInt(), T = ReadInt();
            WriteLine($"Distance between cars after T hours= {V1 * T + S + V2 * T} km");
        }
        static void fifth_task()
        {
            WriteLine("Please enter coefficients A!=0 and B for expression A*x+B=0: ");
            int A = ReadInt(), B = ReadInt();
            float x;
            x = (float) -B / A;
            if (A != 0)
            {
                WriteLine($"x = {x}");
            }
            else
            {
                WriteLine("Value of A cannot be zero");
            }
        }
        static void sixth_task()
        {
            WriteLine("Please enter coefficients A, B, A1, B1: ");
            int a1 = ReadInt(), b1 = ReadInt(), a2 = ReadInt(), b2 = ReadInt();
            WriteLine("Please enter answers C, C1: ");
            int c1 = ReadInt(), c2 = ReadInt();
            float y = (a1 * c2 - a2 * c1) / (a1 * b2 - a2 * b1);
            WriteLine($"x = {(c1 - b1 * y) / a1}, y = {y}");
        }
        static void Main(string[] args)
        {
            WriteLine("First task:");
            first_task();
            WriteLine("Second task:");
            second_task();
            WriteLine("Third task:");
            third_task();
            WriteLine("Fourth task:");
            fourth_task();
            WriteLine("Fifth task:");
            fifth_task();
            WriteLine("Sixth task:");
            sixth_task();
            ReadKey();
        }
    }
}
