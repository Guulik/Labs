using System;
using static System.Console;

namespace lab12
{
    class Program
    {
        static int ReadInt()
        {
            return Convert.ToInt32(ReadLine());
        }
        static void Main(string[] args)
        {
            int number, a, b, c, b1, c1;
            string d;
            string[] num1 = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] num2 = new string[] { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eigty", "ninety"};
            string[] num3 = new string[] { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            WriteLine("Enter the number of task");
            number = ReadInt();
            while (number != 0)
            {
                switch (number)
                {
                    case 1:
                        WriteLine("Task 1");
                        WriteLine("Enter the date of the month");
                        a = ReadInt();
                        WriteLine("Enter the number of the month");
                        b = ReadInt();
                        string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                        if (a <= 0 | a > 31)
                            WriteLine("Date entry error. This date cannot exist\n");
                        else if (a == 31 & (b == 2 | b == 4 | b == 6 | b == 9 | b == 11))
                            WriteLine("Date entry error. This date cannot exist\n");
                        else if (a >= 29 & b == 2)
                            WriteLine("Date entry error. This date cannot exist\n");
                        else
                            WriteLine($"The date you entered is {a} of {months[b-1]}\n");
                        break;
                    case 2:
                        WriteLine("Task 2");
                        WriteLine("Enter direction\nn — North\nw - West\ns - South\ne - East\n");
                        d = ReadLine();
                        WriteLine("Enter the movement");
                        a = ReadInt();
                        switch (d)
                        {
                            case "n":
                                switch (a)
                                {
                                    case -1:
                                        WriteLine($"Direction of the robot - East\n");
                                        break;
                                    case 0:
                                        WriteLine($"Direction of the robot - North\n"); 
                                        break;
                                    case 1:
                                        WriteLine($"Direction of the robot - West\n"); 
                                        break;
                                    default:
                                        WriteLine("Movement error");
                                        break;
                                }
                                break;
                            case "w":
                                switch(a)
                                {
                                    case -1:
                                        WriteLine($"Direction of the robot - North\n"); 
                                        break;
                                    case 0:
                                        WriteLine($"Direction of the robot - West\n");
                                        break;
                                    case 1:
                                        WriteLine($"Direction of the robot - South\n");
                                        break;
                                    default:
                                        WriteLine("Movement error");
                                        break;
                                }
                                break;
                            case "s":
                                switch(a)
                                {
                                    case -1:
                                        WriteLine($"Direction of the robot - West\n"); 
                                        break;
                                    case 0:
                                        WriteLine($"Direction of the robot - South\n"); 
                                        break;
                                    case 1:
                                        WriteLine($"Direction of the robot - East\n"); 
                                        break;
                                    default:
                                        WriteLine("Movement error");
                                        break;
                                }
                                break;
                            case "e":
                                switch(a)
                                {
                                    case -1:
                                        WriteLine($"Direction of the robot is South\n"); 
                                        break;
                                    case 0:
                                        WriteLine($"Direction of the robot is East\n"); 
                                        break;
                                    case 1:
                                        WriteLine($"Direction of the robot is North\n"); 
                                        break;
                                    default:
                                        WriteLine("Movement error");
                                        break;
                                }
                                break;
                            default:
                                Console.WriteLine("Direction error");
                                break;
                        }
                        break;
                    case 3:
                        WriteLine("Task 3");
                        WriteLine("Enter number");
                        a = ReadInt();
                        b = Math.DivRem(a, 10, out c);
                        if (a > 10 & a < 20)
                            WriteLine($"Entered task is {num3[c - 1]}\n");
                        else if (a > 20 & a < 40)
                            WriteLine($"Entered task is {num2[b - 1]}-{num1[c - 1]}\n");
                        else if (c == 0 &  b <= 4)
                            WriteLine($"Entered task is {num2[b - 1]}\n");
                        else
                           WriteLine("There is no task\n");
                        break;
                    case 4:
                        WriteLine("Task 4."); 
                        WriteLine("Enter number");
                        a = Convert.ToInt32(ReadLine());
                        b = Math.DivRem(a, 100, out c);
                        b1 = Math.DivRem(c, 10, out c1);
                        if (a >= 100 & a < 1000)
                        {
                            if (c > 10 & c < 20)
                                Write($"Entered number is {num1[b - 1]} hundred {num3[c1 - 1]} \n");
                            else if (c1 == 0 & b1 <= 9)
                                WriteLine($"Entererd number is {num1[b - 1]} hundred {num2[b1 - 1]} \n");
                            else if (c > 20 & c < 99)
                                Write($"Entered number is {num1[b - 1]} hundred {num2[b1 - 1]}-{num1[c1 - 1]} \n");
                            else if (c <= 9)
                                Write($"Entered number is {num1[b - 1]} hundred {num1[c - 1]} \n");
                        }
                        else
                            WriteLine("The number must be in the range from 100 to 999\n");
                        break;
                    case 5:
                        WriteLine("Task 5."); 
                        WriteLine("Enter number");
                        a = ReadInt();
                        string[] color = new string[] { "White", "Black",  "Green", "Red", "Yellow" };
                        string[] animal = new string[] { "Rat", "Cow", "Tiger", "Hare", "Dragon", "Snake", "Horse", "Lamb", "Monkey", "Hen", "Dog", "Pig" };
                        b = a % 10;
                        b /= 2;
                        c = (a + 8) % 12;
                        WriteLine($"The Year of the {color[b]} {animal[c]}\n");
                        break;
                }
               WriteLine("Enter the task number or 0 to exit");
                number = ReadInt();
            }
        }
    }
}
