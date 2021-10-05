using System;
using static System.Console;
using System.Linq;

namespace _10_lab
{
    class lab10
    {
        static int ReadInt()
        {
            return Convert.ToInt32(ReadLine());
        }
        static void first_task()
        {
            WriteLine("Enter A and B;");
            int A = ReadInt(), B = ReadInt();
            WriteLine($"{(A > 2 && B <= 3 ? "Correct":"Incorrect")}");
        }
        static void second_task()
        {
            WriteLine("Enter A and B and C;");
            int A = ReadInt(), B = ReadInt(), C = ReadInt();
            WriteLine($"{(A < B && B < C ? "Correct" : "Incorrect")}");
        }
        static void third_task()
        {
            WriteLine("Enter integer number");
            int X = ReadInt();
            WriteLine($"{(X%2 == 0 && X/10 > 0 && X/100 == 0 ? "Correct" : "Incorrect")}");
        }
        static void fourth_task()
        {
            WriteLine("Enter 3-digit number");
            string X = ReadLine();
            WriteLine($"{(X[0]<X[1]&& X[1]<X[2] || X[0] > X[1] && X[1] > X[2] ? "Correct" : "Incorrect")}");
        }
        static void fifth_task()
        {
            WriteLine("Enter 4-digit number");
            int X = ReadInt();
            int iks = (X % 10 * 10) + (X % 100/10);
            WriteLine($"{(X / 100 == iks ? "Correct" : "Incorrect")}");
        }
        static void sixth_task()
        {
            WriteLine("Enter A and B and C;");
            int[] sides = {ReadInt(), ReadInt(), ReadInt()};
            int i = Array.IndexOf(sides,sides.Max());
            WriteLine($"{(sides[i] * sides[i] == sides[(i + 1) % 3] * sides[(i + 1) % 3] + sides[(i + 2) % 3] * sides[(i + 2) % 3] ? "Correct" : "Incorrect")}");
        }
        static void seventh_task()
        {
            WriteLine("Enter A and B and C;");
            int A = ReadInt(), B = ReadInt(), C = ReadInt();
            WriteLine($"{(A+B > C || A+C>B || B+C>A? "Exist" : "Doesn`t exist")}");
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
            WriteLine("Sixth task");
            sixth_task();
            WriteLine("Seventh task");
            seventh_task();
        }
    }
}
