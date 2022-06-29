namespace HelloWorld
{
    class Program
    {
        // ДЗ1 Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            
            if (number % 2 == 0) Console.WriteLine($"Число четное - {number}");
                else Console.WriteLine($"Число нечетное - {number}");
        }
    }
}
