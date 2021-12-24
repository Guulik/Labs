using System;
using static System.Console;
namespace _18
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
                        int N = ReadInt(); int[] A = new int[N], B = new int[N];
                        for (int i = 0; i<N; i++)//заполнение массива
                        {
                            A[i] = i % 2 == 0 ? i * 5 : i;
                            B[i] = i % 2 != 0 ? i * 5 : i;   
                        }
                        //вывод массивов до замены
                        Write("A = ");
                        for (int i = 0; i < N; i++) Write(A[i]+" ");
                        Write("\nB = ");
                        for (int i = 0; i < N; i++) Write(B[i]+" ");
                        //основная часть
                        int buf;
                        for (int i = 0; i < N; i++)
                        {
                            buf = A[i];
                            A[i] = B[i];
                            B[i] = buf;
                        }
                        //вывод после замены
                        WriteLine("\nЗаменили...");
                        Write("A = ");
                        for (int i = 0; i < N; i++) Write(A[i] + " ");
                        Write("\nB = ");
                        for (int i = 0; i < N; i++) Write(B[i] + " ");
                        break;

                    case 2:
                        WriteLine("Enter N: ");
                        N = ReadInt(); A = new int[N];
                        float [] b = new float[N];
                        for (int i = 0; i < N; i++) A[i] = i + 1; //заполнение массива 
                        Write("A = ");
                        for (int i = 0; i < N; i++) Write(A[i] + " "); 
                        for (int i = 0; i < N; i++) 
                        {
                            int avg = 0;
                            for (int j = 0; j <= i; j++)
                                avg += A[j];
                            b[i] = (float) avg / (i+1); //почему то иногда ломается и показывает на 1 меньше
                        }
                        Write("\nB = ");
                        for (int i = 0; i < N; i++)  Write(b[i] + " ");
                        break;

                    case 3:
                        WriteLine("Enter N: ");
                        N = ReadInt(); A = new int[N];
                        int nch = 0;
                        Random rnd = new Random();
                        for (int i = 0; i < N; i++) A[i] = rnd.Next(40);
                        Write("A1 = ");
                        for (int i = 0; i < N; i++) Write(A[i] + " ");
                        for (int i = 0; i < N; i++) nch = A[i] % 2 != 0 ? A[i] : nch;
                        for (int i = 0; i < N; i++)
                            A[i] = A[i] % 2 != 0 ? A[i] + nch : A[i];
                        Write("\nA2 = ");
                        for (int i = 0; i < N; i++) Write(A[i] + " ");
                        break;

                    case 4:
                        A = new int[] { 50, 52, 4, 3, 2, 2, -2, 2, 2, 1 };//это для демонстрации;
                        //если нужен рандом, введите число в [], удалите всё, что в {}, раскомментируйте след. строку
                        //rnd = new Random(); for (int i = 0; i < A.Length; i++) A[i] = rnd.Next(1, 50);
                        //бывают наборы данных, где плохо прослеживается работоспособность
                        int min = int.MaxValue, max = -int.MaxValue, L = 0, R = A.Length - 1;
                        Write("A1 = ");
                        for (int i = 0; i < A.Length; i++) Write(A[i] + " ");
                        for (int i = 0; i < A.Length; i++)
                        {
                            if (A[i] < min)
                            {
                                min = A[i]; L = i;
                            }
                            if (A[i] > max)
                            {
                                max = A[i]; R = i;
                            }
                        }
                        buf = R;
                        R = R < L ? L : R;
                        L = buf < L ? buf : L;
                        for (int i = L + 1; i < R; i++) A[i] = 0;
                        Write("\nA2 = ");
                        for (int i = 0; i < A.Length; i++) Write(A[i] + " ");
                        break;

                    case 5:
                        A = new int[] { 50, 1, 2, 3, 4, 5, 6, 7, 8};
                        Write("A1 = ");
                        for (int i = 0; i < A.Length; i++) Write(A[i] + " ");
                        int l = 1, r = 2;
                        //я решил просто применить гномью сортировку
                        //это хоть и неэффективно, зато просто в реализации
                        while (l < A.Length)
                        {
                            if (A[l - 1] > A[l])
                            {
                                buf = A[l];
                                A[l] = A[l - 1];
                                A[l - 1] = buf;
                                l--;
                                if (l > 0) continue;
                            }
                            l = r++;
                        }
                        Write("\nA2 = ");
                        for (int i = 0; i < A.Length; i++) Write(A[i] + " ");
                        break;
                }
                WriteLine("\nEnter the task number or 0 to exit");
                number = ReadInt();
            }
        }
    }
}
