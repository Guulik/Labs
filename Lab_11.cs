using System;
using static System.Console;
using static System.Math;
namespace _11_lab
{
    class Lab_11
    {
        static double dist(int x1, int x2, int y1, int y2)//функция для вычисления расстояния между точками
        {
            return Sqrt(Pow(x2 - x1, 2) + Pow(y2 - y1, 2));
        }
        static int ReadInt()
        {
            return Convert.ToInt32(ReadLine());
        }
        static void first_task()
        {
            WriteLine("Enter A and B:");
            int A = ReadInt(), B = ReadInt();
            WriteLine($"{(A==B ? "0, 0": (Max(A,B), Max(A,B)))}");
        }
        static void second_task()
        {
            WriteLine("Enter 3 numbers: ");
            int A = ReadInt(), B = ReadInt(), C = ReadInt();
            WriteLine($"{Max(A, B) + Max(B, C)}");
        }
        static void third_task()
        {
            WriteLine("Enter A, B, C");
            int xA = ReadInt(), xB = ReadInt(), xC = ReadInt(), yA = ReadInt(), yB = ReadInt(), yC = ReadInt();
            WriteLine($"{(dist(xA,xB,yA,yB) < dist(xA,xB,yA,yC) ? ("B",dist(xA,xB,yA,yB)):("C",dist(xA,xC,yA,yC)))}");
        }
        static void fourth_task()
        {
            WriteLine("Enter 2 coordinates:");
            int x = ReadInt(), y = ReadInt();
            WriteLine($"{(x > 0 && y>0? "1 quarter" : x<0 && y>0 ? "2 quarter": x<0 && y < 0 ? "3 quarter" : "4 quarter")}");
        }
        static void fifth_task()
        {
            WriteLine("Enter number:");
            int x = ReadInt();
            WriteLine($@"{(x > 0 && x % 2 == 0 ? "положительное четное число" 
                : x < 0 && x % 2 == 0 ? "отрицательное четное число" 
                : x > 0 && x % 2 != 0 ? "положительное нечетное число" 
                : x < 0 && x % 2 != 0 ? "отрицательное нечетное число" 
                : "нуль")}");
        }
        static void sixth_task()
        {
            WriteLine("Enter number:");
            int x = ReadInt(), t = x, cnt = 0;
            while (t > 0)
            {
                t /= 10;
                cnt += 1;
            }
            if (x > 0 && x < 1000)
            {
                if (x%2==0)
                    WriteLine($"{(cnt == 1? "четное однозначное число": cnt == 2? "четное двузначное число":"четное трехзначное число")}");

                else
                    WriteLine($"{(cnt == 1 ? "нечетное однозначное число" : cnt == 2 ? "нечетное двузначное число" : "нечетное трехзначное число")}");        
                
            }
            else
            {
                WriteLine("incorrect number");
            }
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
        }
    }
}
