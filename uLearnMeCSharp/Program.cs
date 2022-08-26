using System;

namespace uLearnMeCSharp
{
    internal class Task1
    {
        public static void Main()
        {
            Console.WriteLine(GetGreetingMessage("Student", 10.01));
            Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
            Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));
        }
        private static string GetGreetingMessage(string name, double salary)
        {
            return "Hello, " + name + "," + " your salary is " + Math.Ceiling(salary);

        }
    }
    internal class Task2
    {
        public static void Main()
        {
            Print(GetSquare(42));
        }
        static void Print(int a)
        {
            Console.WriteLine(a);
        }

        static int GetSquare(int n)
        {
            return (int)Math.Pow(n, 2);
        }
    }
    internal class Task3
    {
        static void Main()
        {
            Console.WriteLine(GetLastHalf("I love CSharp!"));
            Console.WriteLine(GetLastHalf("1234567890"));
            Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));
        }
        static string GetLastHalf(string text)
        {
            return text.Substring(text.Length / 2).Replace(" ", "");
        }
    }
    internal class Task4
    {
        public static void Main()
        {
            Console.WriteLine(GetMinX(1, 2, 3));
            Console.WriteLine(GetMinX(0, 3, 2));
            Console.WriteLine(GetMinX(1, -2, -3));
            Console.WriteLine(GetMinX(5, 2, 1));
            Console.WriteLine(GetMinX(4, 3, 2));
            Console.WriteLine(GetMinX(0, 4, 5));

            // А в этих случаях решение существует:
            Console.WriteLine(GetMinX(0, 0, 2) != "Impossible");
            Console.WriteLine(GetMinX(0, 0, 0) != "Impossible");
        }
        private static string GetMinX(int a, int b, int c)
        {
            if (a != 0)
            {
                return (-b / (2.0 * a)).ToString(); // так можно вернуть строковое представление числа
            }
            else if (b != 0)
            {
                return "Impossible";
            }
            else
            {
                return c.ToString();
            }
        }
    }
    internal class Task5
    {
        public static void Main()
        {
            Console.WriteLine(IsLeapYear(2014));
            Console.WriteLine(IsLeapYear(1999));
            Console.WriteLine(IsLeapYear(8992));
            Console.WriteLine(IsLeapYear(1));
            Console.WriteLine(IsLeapYear(14));
            Console.WriteLine(IsLeapYear(400));
            Console.WriteLine(IsLeapYear(600));
            Console.WriteLine(IsLeapYear(3200));
        }
        public static bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }
    }
    internal class Task6
    {
        public static void Main()
        {
            Console.WriteLine(GetMinPowerOfTwoLargerThan(2)); // => 4
            Console.WriteLine(GetMinPowerOfTwoLargerThan(15)); // => 16
            Console.WriteLine(GetMinPowerOfTwoLargerThan(-2)); // => 1
            Console.WriteLine(GetMinPowerOfTwoLargerThan(-100));
            Console.WriteLine(GetMinPowerOfTwoLargerThan(100));

        }
        private static int GetMinPowerOfTwoLargerThan(int number)
        {
            int result = 1;
            while (result <= number)
                result *= 2;
            return result;
        }
    }
    internal class Task7
    {
        public static void Main()
        {
            Console.WriteLine(RemoveStartSpaces("a"));
            Console.WriteLine(RemoveStartSpaces(" b"));
            Console.WriteLine(RemoveStartSpaces(" cd"));
            Console.WriteLine(RemoveStartSpaces(" efg"));
            Console.WriteLine(RemoveStartSpaces(" text"));
            Console.WriteLine(RemoveStartSpaces(" two words"));
            Console.WriteLine(RemoveStartSpaces("  two spaces"));
            Console.WriteLine(RemoveStartSpaces("	tabs"));
            Console.WriteLine(RemoveStartSpaces("		two	tabs"));
            Console.WriteLine(RemoveStartSpaces("                             many spaces"));
            Console.WriteLine(RemoveStartSpaces("               "));
            Console.WriteLine(RemoveStartSpaces("\n\r line breaks are spaces too"));
        }
        public static string RemoveStartSpaces(string text)
        {
            if (char.IsWhiteSpace(text[0])) return text.Substring(1);
            else return text;
        }
    }
}