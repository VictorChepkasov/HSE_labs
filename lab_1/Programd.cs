using System;
class Program
{
    static void Main(string[] args)
    {
        int n, m;
        double x;
        while (true)
        {
            Console.Write("n ? ");
            string a1 = Console.ReadLine();
            try
            {
                checked
                {
                    int p = Convert.ToInt32(a1);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода n!");
                continue;
            }
            n = Convert.ToInt32(a1);
            break;
        }

        while (true)
        {
            Console.Write("m ? ");
            string a1 = Console.ReadLine();
            try
            {
                checked
                {
                    int p = Convert.ToInt32(a1);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода m!");
                continue;
            }
            m = Convert.ToInt32(a1);
            break;
        }

        while (true)
        {
            Console.Write("x ? ");
            string a1 = Console.ReadLine();
            try
            {
                checked
                {
                    double p = Convert.ToDouble(a1);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода x!");
                continue;
            }
            x = Convert.ToDouble(a1);
            break;
        }

        try
        {
            checked
            {
                int res1 = m - n;
                try
                {
                    checked
                    {
                        m--;
                        Console.WriteLine($"n = {n}, m = {m}, m-- - n = {res1}");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Значение m вышло за границы заданного типа!");
                }
            }
            
        }
        catch (OverflowException)
        {
            Console.WriteLine("Невозможно вычислить разность в заданном типе!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Невозможно вычислить разность в заданном типе!");
        }

        bool res2 = m++ < n;
        Console.WriteLine($"n = {n}, m = {m}, m++ < n = {res2}");

        try
        {
            checked
            {
                bool res3 = n++ > m;
                Console.WriteLine($"n = {n}, m = {m}, n++ > m = {res3}");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Значение n вышло за границы заданного типа!");
        }

        if (x < -1.0 || x > 1.0)
        {
            Console.WriteLine("Нельзя вычислить!");
            Environment.Exit(0);
        }
        try
        {
            checked
            {
                double result4 = x * x * x * x - Math.Cos(Math.Asin(x));
                Console.WriteLine($"x = {x}, x^4 - cos(arcsin(x)) = {result4}");
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Число слишком большое/малое для вычисления!");
        }
        catch (Exception)
        {
            Console.WriteLine("Нельзя вычислить!");
        }
    }
}