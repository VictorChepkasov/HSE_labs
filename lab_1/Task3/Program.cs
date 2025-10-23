namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const float floatA = 1000;
            const float floatB = 0.0001F;
            const double doubleA = 1000;
            const double doubleB = 0.0001;

            //считаем выражение с float
            float floatR1 = (float)Math.Pow(floatA - floatB, 3);
            float floatR2 = (float)Math.Pow(floatA, 3) + 3 * floatA * floatB * floatB;
            float floatR3 = -3 * (float)Math.Pow(floatA, 2) * floatB - (float)Math.Pow(floatB, 3);
            float floatResult = (floatR1 - floatR2) / floatR3;

            //считаем выражение с double
            double doubleR1 = Math.Pow(doubleA - doubleB, 3);
            double doubleR2 = Math.Pow(doubleA, 3) + 3 * doubleA * doubleB * doubleB;
            double doubleR3 = -3 * Math.Pow(doubleA, 2) * doubleB - Math.Pow(doubleB, 3);
            double doubleResult = (doubleR1 - doubleR2) / doubleR3;

            System.Console.WriteLine($"Результат вычисления (double) = {doubleResult}");
            System.Console.WriteLine($"Результат вычисления (float) = {floatResult}");
        }
    }

}