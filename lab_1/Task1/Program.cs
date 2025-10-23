using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 0, result1 = 0;
            bool result2, r3;
            double x = 0, result4;
            bool isQuit = false;

            //ввод данных
            while (!isQuit)
            {
                try
                {
                    System.Console.Write("n ? ");
                    string buff = Console.ReadLine();
                    n = int.Parse(buff);
                    isQuit = true;
                }
                catch (FormatException)
                {
                    System.Console.WriteLine("Ошибка ввода n!");
                }
                catch (OverflowException)
                {
                    System.Console.WriteLine("Значение n вышло за границы заданного типа!");
                }
            };

            while (!isQuit)
            {
                try
                {
                    System.Console.Write("m ? ");
                    string buff = Console.ReadLine();
                    m = int.Parse(buff);
                    break;
                }
                catch (FormatException)
                {
                    System.Console.WriteLine("Ошибка ввода m!");
                }
                catch (OverflowException)
                {
                    System.Console.WriteLine("Значение m вышло за границы заданного типа!");
                }
            };

            while (true)
            {
                try
                {
                    System.Console.Write("x ? ");
                    string buff = Console.ReadLine();
                    x = double.Parse(buff);
                    break;
                }
                catch (FormatException)
                {
                    System.Console.WriteLine("Ошибка ввода x!");
                }
            };

            //вычисления
            try
            {
                checked
                {
                    try
                    {
                        checked { ++n; }
                    }
                    catch (Exception)
                    {
                        System.Console.WriteLine("Значение n вышло за границы заданного типа!");
                    }
                    result1 = m - n;
                    System.Console.WriteLine($"n = {n}, m = {m}, m - ++n = {result1}");
                }
            }
            catch (OverflowException)
            {
                System.Console.WriteLine("Невозможно вычислить разницу в заданном типе!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Невозможно вычислить разность в заданном типе!");
            }

            try
            {
                checked
                {
                    result2 = m++ > --n;
                    System.Console.WriteLine($"n = {n}, m = {m}, m++ > --n = {result2}");
                }
            }
            catch (OverflowException)
            {
                System.Console.WriteLine("Невозможно вычислить разницу в заданном типе!");
            }

            try
            {
                checked {
                    try
                    {
                        checked { ++n; }
                    }
                    catch (OverflowException)
                    { System.Console.WriteLine("Значение n вышло за границы заданного типа!"); }
                    r3 = m < n;
                    try { checked { m--; }} catch (OverflowException) {System.Console.WriteLine("Значение m вышло за границы заданного типа!");}
                    System.Console.WriteLine($"n = {n}, m = {m}, m-- < ++n = {r3}");
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Невозможно вычислить разницу в заданном типе!");
            }

            if (x < -2 || x > 0)
            {
                System.Console.WriteLine("Нельзя вычислить!");
            }
            else
            {
                try
                {
                    checked {
                        result4 = System.Math.Asin(System.Math.Abs(x + 1));
                        System.Console.WriteLine($"x = {x}, arcsin(|x + 1|) = {result4}");
                    }
                }
                catch (OverflowException) {
                    System.Console.WriteLine("Число слишком большое/малое для вычисления!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Нельзя вычислить!");
                }
            }

        }
    }
}