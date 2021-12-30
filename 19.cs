using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

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
            Random rnd = new Random();
            while (number != 0)
            {
                switch (number)
                {
                    //для каждой задачи я сделал пример данных, на котором видна работа алгоритма. От N он не зависит
                    //Если нужен массив размера N, раскомментируйте строку с рандомом и удалите данные массива в {}
                    case 1:
                        WriteLine("Enter N: ");
                        int N = ReadInt();
                        var ar = new List<int>() { 10, 87, 12, 5, 5, 5,5,5,5, 10 };
                        //for (int i = 0; i < N; i++) ar.Add(rnd.Next(100));
                        foreach (var n in ar) Write(n+" ");
                        WriteLine();
                        for (int i = 1; i < ar.Count(); i++)
                            while (ar[i - 1] == ar[i]) ar.Remove(ar[i]);
                        foreach (var n in ar) Write(n + " ");
                        break;
                    case 2:
                        WriteLine("Enter N: ");
                        N = ReadInt();
                        ar = new List<int>() { 10, 12, 5, 12, 62, 2, 12, 5, 5, 5, 10 };
                        //for (int i = 0; i < N; i++) ar.Add(rnd.Next(100));
                        foreach (var n in ar) Write(n + " ");
                        var nums = ar.GroupBy(i => i).Select(c=>c.Key).ToList();
                        var counts = ar.GroupBy(i => i).Select(c => c.Count()).ToList();
                        var arr = new List<int>();
                        foreach (int a in ar)
                            for (int i = 0; i < nums.Count(); i++)
                                if (a == nums[i] && counts[i] != 2)
                                    arr.Add(a);
                        WriteLine();
                        foreach (var a in arr) Write(a + " ");
                        break;
                    case 3:
                        WriteLine("Enter N: ");
                        N = ReadInt();
                        ar = new List<int>() { -1, 77, 9765, 12, 25, 2, 1000000 };
                        //for (int i = 0; i < N; i++) ar.Add(rnd.Next(100));
                        foreach (var n in ar) Write(n + " ");
                        ar.Insert(ar.IndexOf(ar.Min()), 0);
                        ar.Insert(ar.IndexOf(ar.Max())+1, 0);
                        WriteLine();
                        foreach (var a in ar) Write(a + " ");
                        break;
                    case 4:
                        WriteLine("Enter N: ");
                        N = ReadInt();
                        ar = new List<int>() { 1, 77, 95, -12, -25, -7 };
                        //for (int i = 0; i < N; i++) ar.Add(rnd.Next(100));
                        foreach (var n in ar) Write(n + " ");
                        for (int i = 0; i < ar.Count(); i++)
                            if (ar[i] < 0)
                                ar.Insert(i+1, 0);
                        WriteLine();
                        foreach (var a in ar) Write(a + " ");
                        break;
                    case 5:
                        WriteLine("Enter N: ");
                        N = ReadInt();
                        ar = new List<int>() { 1, 77, 95, -12, -25, -7 };
                        //for (int i = 0; i < N; i++) ar.Add(rnd.Next(100));
                        foreach (var n in ar) Write(n + " ");
                        for (int i = 0; i < ar.Count(); i++)
                            if (ar[i] > 0)
                            {
                                ar.Insert(i, 0);
                                i++;
                            }
                        WriteLine();
                        foreach (var a in ar) Write(a + " ");
                        break;
                }
                WriteLine("\nEnter the task number or 0 to exit");
                number = ReadInt();
            }
        }
    }
}
