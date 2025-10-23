namespace Task2;

internal class Program
{
    static void Main(string[] args)
    {
        int n = 0, countOdd = 0, length = 0;
        bool isQuit = false;

        //ввод данных
        Console.WriteLine("Введите элементы послдовательности, закончив её нулём: ");

        while (!isQuit)
        {
            try
            {
                string buff = Console.ReadLine();
                n = int.Parse(buff);
                if (n == 0)
                {
                    isQuit = true;
                    continue;
                }
                else if (n % 2 != 0)
                {
                    countOdd += 1;
                }
                length += 1;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода элемента! Элемент дожлен быть целым числом");
                isQuit = true;
            }
        }

        if (length == 0)
        {
            Console.WriteLine($"Последовательность пустая");
        }
        else
        {
            //вывод
            Console.WriteLine($"Количество нечетных элементов этой последовательности = {countOdd}");
        }
    }
}
