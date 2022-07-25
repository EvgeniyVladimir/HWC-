// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

namespace NomeWorkTask27
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите число");
            string? str = (Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                sum +=
                int.Parse((str[i]).ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
