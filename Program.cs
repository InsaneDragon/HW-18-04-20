using System;
namespace HW
{
    class Program
    {
        delegate T Operation<T>(T x, T y);
        static void Main(string[] args)
        {
            bool work = true;
            while (work == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Operations:");
                System.Console.WriteLine("+");
                System.Console.WriteLine("-");
                System.Console.WriteLine("*");
                System.Console.WriteLine("/");
                System.Console.WriteLine("quit");
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.Write("Operation:");
                string operation = Console.ReadLine();
                Console.Clear();
                if (operation != "quit")
                {
                    System.Console.Write("First Number:");
                    string first = System.Console.ReadLine();
                    System.Console.Write("Second Number:");
                    string second = System.Console.ReadLine();
                    Calculator<string> Operations = new Calculator<string>();
                    double num, num2;
                    bool firstnum = double.TryParse(first, out num);
                    bool secondnum = double.TryParse(second, out num2);
                    if (firstnum == true && secondnum == true)
                    {
                        switch (operation)
                        {
                            case "*": { Operation<double> del = Calculator<double>.Multiply<double>; double result = del.Invoke(num, num2); Console.WriteLine("result:" + result); } break;
                            case "-": { Operation<double> del = Calculator<double>.Minus<double>; double result = del.Invoke(num, num2); Console.WriteLine("result:" + result); } break;
                            case "/": { if (num2 != 0) { Operation<double> del = Calculator<double>.Divide<double>; double result = del.Invoke(num, num2); Console.WriteLine("result:" + result); } else { System.Console.WriteLine("Error"); } } break;
                            case "+": { Operation<double> del = Calculator<double>.Plus<double>; double result = del.Invoke(num, num2); Console.WriteLine("result:" + result); } break;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("Please write a number");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else { work = false; }
            }
        }
    }
    class Calculator<T>
    {
        public static T Plus<T>(T first, T second)
        {
            return (dynamic)first + (dynamic)second;
        }
        public static T Minus<T>(T first, T second)
        {
            return (dynamic)first - (dynamic)second;
        }
        public static T Multiply<T>(T first, T second)
        {
            return (dynamic)first * (dynamic)second;

        }
        public static T Divide<T>(T first, T second)
        {
            return (dynamic)first / (dynamic)second;

        }
    }
}