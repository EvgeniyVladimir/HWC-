namespace HelloWorld
{
    class Program
    {
        // ДЗ2_Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string str = number.ToString();
            
            char ch = str[2];
            if (ch != null)
            {
                Console.WriteLine($"третьей цифры нет");
            }
            Console.WriteLine(ch);
           
        }
    }
}