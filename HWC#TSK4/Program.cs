namespace HelloWorld
{
    class Program
    {
        // ДЗ1 Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. (не включая N)
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int N = Convert.ToInt32(Console.ReadLine());
            int a = 1; 
            for (a = 1; a < N; a++)
            if (a % 2 == 0) 
            Console.WriteLine(a);
        }
    }
}
