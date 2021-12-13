using System;
using static System.Console;
namespace _15
{
    class Program
    {
        static int ReadInt()
        {
            return Convert.ToInt32(ReadLine());
        }
        static double ReadDouble()
        {
            return double.Parse(ReadLine());
        }
        static double PowerA3 (double A, double B)
        {
            B = A * A * A;
            return B;
        }

        static int Sign(double X)
        {
            return X > 0 ? 1 : X == 0 ? 0 : -1;
        }
        
        static double RingS(double R1, double R2)
        {
            double pi = 3.14;
            return (pi * R1 * R1) - (pi * R2 * R2); 
        }
        
        static int Quarter(double x, double y)
        {
            return (x > 0 && y > 0) ? 1 : (x < 0 && y > 0) ? 2 : (x < 0 && y < 0) ? 3 : 4;
        }

        static double Fact2(int N)
        {
            double res = 1;
                for (int i = (N%2 != 0) ? 1 : 2; i <= N; i += 2)
                    res *= Convert.ToDouble(i);
            return res;

        }
        static void Main(string[] args)
        {
            WriteLine("Enter number task: ");
            int number = ReadInt();
            while (number != 0)
            {
                switch (number)
                {
                    case 1:
                        double A = 0, B = 0;
                        for (int i = 0; i<5; i++)
                        {
                            WriteLine("Enter A: ");
                            A = ReadDouble();
                            WriteLine(PowerA3(A, B));
                        }
                        break;
                    case 2:
                        WriteLine("Enter A and B: ");
                        A = ReadDouble(); B = ReadDouble();
                        WriteLine(Sign(A) + Sign(B));
                        break;
                    case 3:
                        for (int i = 0; i < 3; i++)
                        {
                            WriteLine("Enter R1 and R2: ");
                            double R1 = ReadDouble(), R2 = ReadDouble();
                            WriteLine(RingS(R1, R2));
                        }
                        break;
                    case 4:
                        for (int i = 0; i < 3; i++)
                        {
                            WriteLine("Enter x and y: ");
                            double x = ReadDouble(), y = ReadDouble();
                            WriteLine(Quarter(x, y));
                        }
                        break;
                    case 5:
                        WriteLine("Enter N: ");
                        int N = ReadInt();
                        WriteLine(Fact2(N));
                        break;
                }
                WriteLine("Enter the task number or 0 to exit");
                number = ReadInt();
            }
        }
    }
}
