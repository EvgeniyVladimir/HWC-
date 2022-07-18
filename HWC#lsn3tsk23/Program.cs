namespace NomeWorkTask23
{
    // Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                PrintCube(i);
            }
        }

        public static void PrintCube(int a)
        {
            Console.WriteLine(Math.Pow(a,3));
        }
    }
}
