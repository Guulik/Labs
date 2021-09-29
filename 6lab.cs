using System;
using static System.Console;
using static System.Math;

namespace _6_lab
{
    class Program
    {
        static int ReadInt()
        {
            return Convert.ToInt32(ReadLine());
        }
        static void first_task()
        {
            int A = ReadInt(), B = ReadInt();
            (A, B) = (B, A);
            WriteLine($"1) A={A} B={B}");
        }
        static void sec_task()
        {
            int A = ReadInt(), B = ReadInt(), C = ReadInt();
            (A, B, C) = (C, A, B);
            WriteLine($"2) A={A} B={B} C={C}");
        }
        static void third_task()
        {
            int A = ReadInt(), B = ReadInt(), C = ReadInt();
            (A, B, C) = (B, C, A);
            WriteLine($"3) A={A} B={B} C={C}");
        }
        static void fourth_task()
        {
            int x = ReadInt();
            double y = 3 * Pow(x, 6) - 6 * Pow(x, 2) - 7;
            WriteLine($"4) Expression value = {y}");

        }
        static void fifth_task()
        {
            int x = ReadInt();
            double y = 4 * Pow(x-3, 6) - 7 * Pow(x-3, 2) + 2;
            WriteLine($"5) Expression value = {y}");

        }
        static void sixth_task()
        {
            int A = ReadInt();
            int aux = A * A;
            WriteLine($"6) A^8 = {aux * aux * aux}");
        }
        static void seventh_task()
        {
            int A = ReadInt();
            int aux = A * A * A;
            WriteLine($"7) A^15 = {aux * aux * aux * aux * aux}");
        }
        static void Main(string[] args)
        {
            first_task();
            sec_task();
            third_task();
            fourth_task();
            fifth_task();
            sixth_task();
            seventh_task();
        }
    }
}
