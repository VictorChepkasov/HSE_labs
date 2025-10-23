using System;

class Program
{
    const int N = 140;
    const double EPS = 0.0001;
    const int K = 10;
    const double A = -2;
    const double B = -0.1;

    static void Main()
    {
        // считаем значения для разных x
        for (int i = 0; i <= K; i++)
        {
            double x = A + i * (B - A) / K;
            double sn = CalcBySum(x, N);
            double se = CalcByEpsilon(x, EPS);
            double y = CalcByMath(x);

            Console.WriteLine($"x = {x:F2} sn = {sn:F8} se = {se:F8} y = {y:F8}");
        }
    }

    static double CalcByMath(double x)
    {
        return Math.Log(1.0 / (2 + 2 * x + x * x));
    }

    static double CalcBySum(double x, int n)
    {
        double sum = 0.0;
        for (int k = 1; k <= n; k++)
        {
            double term = Math.Pow(-1, k) * Math.Pow(x + 1, 2 * k) / k;
            sum += term;
        }
        
        return sum;
    }

    static double CalcByEpsilon(double x, double eps)
    {
        bool isQuit = false;
        double sum = 0.0;
        int k = 1;

        while (!isQuit)
        {
            double term = Math.Pow(-1, k) * Math.Pow(x + 1, 2 * k) / k;
            sum += term;

            if (Math.Abs(term) < eps)
                isQuit = true;
            k++;
        }

        return sum;
    }
}