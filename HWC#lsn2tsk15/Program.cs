namespace HelloWorld
{
    class Program
    {
        // ДЗ2_Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
        static void Main(string[] args)
        {
                     
            Console.WriteLine("Введите число дня недели: ");
            int number = Convert.ToInt32(Console.ReadLine());
             
            if(number < 6)
            {
                Console.WriteLine($"Рабочий день");
            }
            if (number > 5) Console.WriteLine($"Выходной день");
                                
        }
    }
}