using Tyuiu.ZaharovVV.Sprint3.Task0.V16.Lib;
namespace Tyuiu.ZaharovVV.Sprint3.Task0.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Захаров В. В. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Захаров Владимир Владимирович | ИСТНб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет произведение     *");
            Console.WriteLine("* по формуле.                                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            int x = 5, kEnd = 6, kStart = 1;
            Console.WriteLine("x = " + x);
            Console.WriteLine("Начальное k = " + kStart);
            Console.WriteLine("Конечное k = " + kEnd);
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(ds.GetMultiplySeries(x, kStart, kEnd));

        }
    }
}