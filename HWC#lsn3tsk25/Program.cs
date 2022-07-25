// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

namespace NomeWorkTask25
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(Math.Pow(a,b));
            // int count = b;
            int number = a;
            for (int i = 1; i < b; i++)
            {
                number = number * a;
            }
            Console.WriteLine(number);
        }
    }
}
