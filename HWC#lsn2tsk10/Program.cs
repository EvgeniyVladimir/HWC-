namespace HelloWorld
{
    class Program
    {
        // ДЗ2_Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string str = number.ToString();
            char ch = str[1];
            Console.WriteLine(ch);
        }
    }
}