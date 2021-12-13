using System;
using static System.Console;

namespace _14
{
    class Program
    {
        static int ReadInt()
        {
            return Convert.ToInt32(ReadLine());
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
                        WriteLine("Enter A: ");
                        int A = ReadInt();
                        WriteLine("Enter B: ");
                        int B = ReadInt();
                        for (int i = A; i<=B; i++)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                WriteLine(i);
                            }
                        }
                        break;
                    case 2:
                        WriteLine("Enter A: ");
                        A = ReadInt();
                        WriteLine("Enter B: ");
                        B = ReadInt();
                        while (A - B >= 0)
                        {
                            A -= B;
                        }
                        WriteLine("Untaken part = " + A);
                        break;
                    case 3:
                        WriteLine("Enter N: ");
                        int n = ReadInt(),k=0,s=0;
                        while (s < n)
                        {
                            k++;
                            s += k;
                        }
                        WriteLine($"K = {k} sum = {s}");
                        break;
                    case 4:
                        WriteLine("Enter P(percents): ");
                        float p = 1+(float.Parse(ReadLine())/100),S = 1000;
                        k = 0;
                        while (S <= 1100)
                        {
                            S *= p;
                            k++;
                        }
                        WriteLine($"Mounths: {k}, deposit = {S}");
                        break;
                    case 5:
                        WriteLine("Enter A: ");
                        A = ReadInt();
                        WriteLine("Enter B: ");
                        B = ReadInt();
                            while (A != B)
                            {
                            if (A > B)
                                A -= B;
                            else
                                B -= A;
                            }
                        WriteLine("NOD = " + A);
                        break;
                    case 6:
                        WriteLine("Enter N:");
                        int f1 = 1, f2 = 1, f = 0;
                        k = 2;
                        n = ReadInt();
                        while (f < n)
                        {
                            f = f2 + f1;
                            f1 = f2;
                            f2 = f;
                            k++;
                        }
                        WriteLine("K = " + k);
                        break;
                }
                WriteLine("Enter the task number or 0 to exit");
                number = ReadInt();
            }
        }
    }
}
