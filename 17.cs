using System;
using static System.Console;

namespace _17
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
                        WriteLine("Enter K: ");
                        int K = ReadInt();
                        WriteLine("Enter L: ");
                        int L = ReadInt(), avg = 0;
                        int[] ar = new int[N];
                        for (int i = 0; i < N; i++)
                            ar[i] = i;
                        for (int i = K; i <= L; i++)
                            avg += ar[i];
                        WriteLine($"Average = {avg/(L-K)}");
                    break;
                    case 2:
                        WriteLine("Enter N: ");
                        N = ReadInt();
                        ar = new int[N]; int cnt = 0;
                        for (int i = 0; i < N; i++) 
                            ar[i] = i * 3;//так образуют
                            //ar[i] = (i % 2 == 0) ? i / 2 : 3 * i + 1; //так нет
                        for (int i = 1; i < N; i++)
                            if (ar[i - 1] < ar[i])
                                cnt +=1 ;
                        WriteLine($"{(cnt == N-1 ? $"da, {ar[N-1] - ar[N - 2]}":0)}");
                        break;
                    case 3:
                        WriteLine("Enter N: ");
                        N = ReadInt();
                        ar = new int[N]; 
                        for (int i = 0; i < N; i++)
                            ar[i] = (i % 3 == 1) ? i : 3 * i + 2;
                        int min = int.MaxValue;
                        for (int i = 1; i < N; i += 2)
                            if (ar[i] < min)
                                min = ar[i];
                        WriteLine($"min element = {min+1}"); //здесь и далее считаем, что номер = индекс+1
                        break;
                    case 4:
                        WriteLine("Enter N: ");
                        N = ReadInt();
                        ar = new int[N]; int Lc_max = 0;
                        for (int i = 0; i < N; i++)
                            ar[i] = (i % 2 != 0) ? i + 2 : i;
                        for (int i = 1; i < N - 1; i++)
                            if (ar[i] > ar[i - 1] && ar[i] > ar[i + 1])
                                Lc_max = i;
                        WriteLine(Lc_max+1);
                        break;
                    case 5:
                        WriteLine("Enter N: ");
                        N = ReadInt();
                        ar = new int[N];
                        for (int i = 0; i < N; i++)
                            ar[i] = (i == 1 || i == 3)? 1000 : i;
                        for (int i = 0; i < N-1; i++)
                            for (int j = i + 1; j < N; j++)
                                if (ar[i] == ar[j]) WriteLine($"first: {i+1} second: {j+1}");
                        break;
                }
                WriteLine("\nEnter the task number or 0 to exit");
                number = ReadInt();
            }
        }
    }
}
