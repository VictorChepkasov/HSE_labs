using System;

class Program
{
    const int N = 40;
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

            Console.WriteLine($"X = {x:F2} SN = {sn:F8} SE = {se:F8} y = {y:F8}");
        }
    }

    static double CalcByMath(double x)
    {
        return Math.Log(1.0 / (2 + 2 * x + x * x));
    }

    static double CalcBySum(double x, int n)
    {
        double sum = 0.0;
        double exp = -(x + 1) * (x + 1);
        double currentPower = exp;

        for (int k = 1; k <= n; k++)
        {
            double term = currentPower / k;
            sum += term;
            currentPower *= exp;
        }
        
        return sum;
    }

    static double CalcByEpsilon(double x, double eps)
    {
        bool isQuit = false;
        double sum = 0.0;
        double exp = -(x + 1) * (x + 1);
        double currentPower = exp;
        int k = 1;

        while (!isQuit)
        {
            double term = currentPower / k; 
            sum += term;

            if (Math.Abs(term) < eps)
                isQuit = true;

            currentPower *= exp;
            k++;
        }

        return sum;
    }
}