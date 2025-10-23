namespace Task2;

internal class Program
{
    static void Main(string[] args)
    {
        int n = 0;
        double p = 1.0;
        bool isQuit = false;

        /*
        Задача 58:
        p = (1-1/2)(1-1/4)(1-1/6)...(1-1/2n)
        */

        //ввод данных
        System.Console.WriteLine("Введите целое число n: ");

        while (!isQuit)
        {
            try
            {
                string buff = Console.ReadLine();
                n = int.Parse(buff);
                if (n <= 0)
                {
                    Console.WriteLine("Невозможно посчитать для n <= 0");
                }
                else
                {
                    isQuit = true;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода n!");
            }
        }
        
        //считаем p
        for (int numForP = 2; numForP <= 2 * n; numForP += 2)
        {
            p *= 1.0 - (1.0 / numForP);
        }

        //вывод p
        Console.WriteLine($"p = {p}");
    }
}
