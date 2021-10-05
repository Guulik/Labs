using System;
using static System.Console;

namespace _9_Lab
{
    class Lab_9
    {
        static int ReadInt()
        {
            return Convert.ToInt32(ReadLine());
        }
        static void first_task()
        {
            WriteLine("Enter seconds below: ");
            int N = ReadInt();
            WriteLine($"{N % 60} seconds passed since the last minute;");
        }
        static void second_task()
        {
            WriteLine("Enter number of the current day: ");
            int K = ReadInt();
            WriteLine($"{K % 7} is weekday number;");
        }
        static void third_task()
        {
            WriteLine("Enter number of the current day and current weekday");
            int K = ReadInt(), N = ReadInt();
            WriteLine($"{N + K % 7 - 1} is weekday number;");
        }
        static void fourh_task()
        {
            WriteLine("Enter dimensions of the big reactangle and side of a square:");
            int A=ReadInt(), B = ReadInt(), C = ReadInt();
            int count = A * B / (C * C);
            WriteLine($"{count} - count of rects; {A * B - C * C * count} - is unoccupied sqaure;");
        }
        static void fifth_task()
        {
            WriteLine("Enter number of current year:");
            int N = ReadInt();
            WriteLine($"{(N % 10 == 0 ? N / 100 : N/100+1)} - is the current century");
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
            fourh_task();
            WriteLine("Fifth task:");
            fifth_task();
            ReadKey();
        }
    }
}
