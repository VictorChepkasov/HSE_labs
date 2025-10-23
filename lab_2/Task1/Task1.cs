namespace Task1;

internal class Program
{
    static void Main(string[] args)
    {
        int n = 0, curValue = int.MinValue, maxValue = int.MinValue, maxPosition = 0;
        bool isConvert = false;

        /*
        Задача 7:
        Дана последовательность из n целых чисел. Найти номер максимального элемента в этой последовательности.
        */

        //ввод данных
        while (!isConvert)
        {
            try
            {
                Console.Write("Введите n: ");
                string buff = Console.ReadLine();
                n = int.Parse(buff);
                if (n <= 0)
                {
                    Console.WriteLine("Невозможно посчитать для n <= 0");
                }
                else
                {
                    isConvert = true;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода n!");
            }
        }

        //находим индекс максимального элемента пос-ти
        for (int index = 1; index <= n; index++)
        {
            try
            {
                curValue = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Элемент не является целым числом");
                return;
            }

            if (curValue > maxValue)
            {
                maxValue = curValue;
                maxPosition = index; 
            }
        }

        //вывод
        Console.WriteLine($"Номер максимального элемента = {maxPosition}");
    }
}