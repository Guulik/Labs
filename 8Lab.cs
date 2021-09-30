using System;
using static System.Console;

namespace Lab8
{
    class Program
    {
        static int ReadInt()
        {
            return Convert.ToInt32(ReadLine());
        }
        static void first_task()
        {
            WriteLine("Enter how much bytes the file occupies:");
            int bytes = ReadInt();
            WriteLine($"{bytes} Bytes = {bytes / 1024} KiloByte(s)");
        }
        static void second_task()
        {
            WriteLine("Enter A length and B length (A>B):");
            int A = ReadInt(), B = ReadInt();
            if (A > B) WriteLine($"{A / B} so many segments B includes A");
            else WriteLine("B must be less than A");
        }
        static void third_task()
        {
            WriteLine("Enter A length and B length (A>B):");
            int A = ReadInt(), B = ReadInt();
            if (A > B) WriteLine($"Unoccupied length = {A-(A/B*B)}");
            else WriteLine("B must be less than A");
        }

        static void fourth_task()
        {
            WriteLine("Enter two-digit number to reverse:");
            int num = ReadInt();
            int revnum = num % 10 * 10 + num / 10;
            WriteLine($"Reversed number is {revnum}");
        }
        static void fifth_task()
        {
            WriteLine("Enter three-digit number:");
            int num3 = ReadInt();
            WriteLine($"Answer is {num3 % 100 * 10 + num3 / 100}");
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
            ReadKey();
        }
    }
}
