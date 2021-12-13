using System;
using static System.Console;

namespace _16
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
                        WriteLine("Enter N: ");
                        int N = ReadInt();
                        int[] mas = new int[N];
                        int k = 1;
                        for (int i = 1; i < N * 2; i += 2) 
                        {
                            mas[i - k] = i;
                            k++;
                        }
                        for (int i = 0; i < N; i++)
                            Write(mas[i]+ " ");
                        break;
                    case 2:
                        WriteLine("Enter N: ");
                        N = ReadInt();
                        int[] arr = new int[N];
                        WriteLine("Enter A: "); int A = ReadInt();
                        WriteLine("Enter D: "); int D = ReadInt();
                        for (int i = 0; i < N; i++)
                        {
                            int temp = 1;
                            for (int j = 0; j < i; j++)                            
                                temp *= D;
                            arr[i] = A * temp;
                        }
                        for (int i = 0; i < N; i++)
                            Write(arr[i] + " ");
                        break;
                    case 3:
                        WriteLine("Enter N: "); N = ReadInt();
                        int[] ar = new int[N];
                        WriteLine("Enter A: "); A = ReadInt();
                        WriteLine("Enter B: "); int B = ReadInt();
                        ar[0] = A; ar[1] = B;
                        for (int i = 2; i < N; i++)
                            ar[i] = ar[i - 1] + ar[i - 2];
                        for (int i = 0; i < N; i++)
                            Write(ar[i] + " ");
                        break;
                    case 4:
                        WriteLine("Enter N: "); N = ReadInt();
                        int[] a = new int[N];
                        for (int i = 0; i < N; i++)
                            a[i] = i;
                        k = 0;
                        for (int i = 0; i < N; i++)
                        {
                            Write(a[(i % 2 == 0) ? i-k : N - i+k] + " ");
                            if (i%2 != 0)
                                k++;
                        }
                        break;
                    case 5:
                        WriteLine("Enter N: "); N = ReadInt();
                        int[] AR = new int[N];
                        for (int i = 0; i < N; i++)
                            AR[i] = i;
                        for (int i = 0; i < N; i++)
                            if (i % 2 == 0)
                                Write(AR[i]+" ");
                        Write('\n');
                        for (int i = 0; i < N; i++)
                            if (i % 2 != 0)
                                Write(AR[N-i]+" ");
                        break;
                }
                WriteLine("\nEnter the task number or 0 to exit");
                number = ReadInt();
            }
        }
    }
}
