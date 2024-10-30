using Tyuiu.ZaharovVV.Sprint3.Task6.V4.Lib;

namespace Tyuiu.ZaharovVV.Sprint3.Task6.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Захаров В. В. | ИСТНб-24-1";
            int ST, END;
            Console.WriteLine("Start = ");
            ST = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("End = ");
            END = Convert.ToInt16(Console.ReadLine());

            DataService DS = new DataService();
            Console.WriteLine("РЕЗУЛЬТАТ: " + DS.GetSumTheDivisors(ST, END));
            Console.ReadKey();
        }
    }
}