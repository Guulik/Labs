using System;
using static System.Console;

namespace _13
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
                        WriteLine("Enter 1 kg cost");
                        float n = ReadInt();
                        for (double i = 0.1; i<1; i+=0.1)
                        {
                            double res = n * i;
                            string result = String.Format("{0:f1}", res);
                            string I = String.Format("{0:f1}", i);
                            WriteLine($"{I} kgs = {result}");
                        }
                        break;
                    case 2:
                        double p = 1;
                        Write("Enter N:");
                        int N = ReadInt();

                        for (int i = 1; i <= N; i++)
                        {
                            p = p * (1 + 0.1 * i);
                        }
                        WriteLine("Result=" + p);
                        break;
                    case 3:
                        int rez = 0;
                        WriteLine("Enter N:");
                        int en = ReadInt();
                        for (int i = 1; i <= (2*en-1); i+=2)
                        {
                            rez += i;
                            WriteLine($"Result = {rez}");
                        }    
                        break;
                    case 4:
                        WriteLine("Enter A: ");
                        float a = float.Parse(ReadLine()), aPow = 1, rezult = 1; 
                        WriteLine("Enter N: ");
                        int eN = ReadInt();
                        for (int i = 1; i <= eN; i++)
                        {
                            aPow = a*aPow;
                            rezult += aPow;
                        }
                        WriteLine($"Result = {rezult}");
                        break;
                    case 5:
                        double sum = 1;
                        WriteLine("Enter N: ");
                        int EN = ReadInt();
                        WriteLine("Enter A: ");
                        double A = double.Parse(ReadLine());
                        for (int i = 1; i <= EN; i++)
                        {
                            sum += Math.Pow(-A, i);
                        }
                        WriteLine($"Result = {sum}");
                        break;
                }
                WriteLine("Enter the task number or 0 to exit");
                number = ReadInt();
            }
        }
    }
}
