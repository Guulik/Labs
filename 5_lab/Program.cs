using System;
using static System.Console;
using static System.Math;

namespace _5_lab
{
    class Program
    {
        static double dist(int x1, int x2, int y1, int y2)//функция для вычисления расстояния между точками
        {
            return Sqrt(Pow(x2 - x1, 2) + Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            
            //task 1
            int px1=2, py1=6, px2, py2;
            double distance;

            WriteLine("Enter 2 coordinates of the second point: ");
            (px2,py2) = (Convert.ToInt32(ReadLine()), Convert.ToInt32(ReadLine()));//Коретжное присваивание

            distance = dist(px1,px2,py1,py2);
            WriteLine(distance);
           

            //Task 2
            int A, B, C;

            WriteLine("Enter A, B, C: ");
            (A, B, C) = (Convert.ToInt32(ReadLine()), Convert.ToInt32(ReadLine()), Convert.ToInt32(ReadLine()));

            WriteLine($"AC= {C-A} BC= {C-B} Sum= {2*C-A-B}");//Для вывода нескольких значений используем интерполяцию
            

            //Task 3
            WriteLine("Enter A, B, C again: ");
            (A, B, C) = (Convert.ToInt32(ReadLine()), Convert.ToInt32(ReadLine()), Convert.ToInt32(ReadLine()));

            if ((A < C && B > C) || (A > C && B < C))
            {
                WriteLine($"Desired value= {Abs(C - A) * Abs(B - C)}");
            }
            else
            {
                WriteLine("C is not located between A and B");
            }


            //task 4
            int rx1, ry1, rx2, ry2;

            WriteLine("Enter 2 coordinates of the first point of rectangle: ");
            (rx1, ry1) = (Convert.ToInt32(ReadLine()), Convert.ToInt32(ReadLine()));
            WriteLine("Enter 2 coordinates of the second point of rectangle: ");
            (rx2, ry2) = (Convert.ToInt32(ReadLine()), Convert.ToInt32(ReadLine()));

            WriteLine($"Rectangle`s square= {Abs((rx2 - rx1) * (ry2 - ry1))}, perimeter= {2 * Abs(rx2 - rx1 + (ry2 - ry1))}");


            //task 5
            int tx1, ty1, tx2, ty2, tx3, ty3;
            double ta, tb, tc;

            WriteLine("Enter 2 coordinates of the first point of triangle: ");
            (tx1, ty1) = (Convert.ToInt32(ReadLine()), Convert.ToInt32(ReadLine()));
            WriteLine("Enter 2 coordinates of the second point of triangle: ");
            (tx2, ty2) = (Convert.ToInt32(ReadLine()), Convert.ToInt32(ReadLine()));
            WriteLine("Enter 2 coordinates of the third point of triangle: ");
            (tx3, ty3) = (Convert.ToInt32(ReadLine()), Convert.ToInt32(ReadLine()));

            ta = dist(tx1, tx2, ty1, ty2);
            tb = dist(tx2, tx3, ty2, ty3);
            tc = dist(tx3, tx1, ty3, ty1);
            double semiper = (ta + tb + tc) / 2;

            WriteLine($"Perimeter= {semiper * 2}, Sqaure= {Sqrt(semiper * (semiper - ta) * (semiper - tb) * (semiper - tc))}");
            ReadKey(true);//Чтобы консоль закрывалась при нажатии клавиши, а не сразу по завершении кода
        }
    }
}
