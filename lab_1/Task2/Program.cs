namespace System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            bool isConvert, inCircle, inTri1, inTri2;

            //ввод данных
            do
            {
                System.Console.Write("x ? ");
                string buff = System.Console.ReadLine();
                isConvert = double.TryParse(buff, out x);
                if (isConvert == false)
                    System.Console.WriteLine("Ошибка ввода x!");
            } while (isConvert == false);

            do
            {
                System.Console.Write("y ? ");
                string buff = System.Console.ReadLine();
                isConvert = double.TryParse(buff, out y);
                if (isConvert == false)
                    System.Console.WriteLine("Ошибка ввода y!");
            } while (isConvert == false);

            //определяем, входит ли переменная в область
            inCircle = Math.Pow(5 - x, 2) + Math.Pow(0 - y, 2) <= 25;
            inTri1 = x >= 0 && y >= 0 && y <= -0.5 * x + 5;
            inTri2 = x >= 0 && y <= 0 && y >= 0.5 * x - 5;

            System.Console.Write(inCircle || inTri1 || inTri2);
        }
    }

}