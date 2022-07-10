namespace HelloWorld
{
    class Program
    {
        // ДЗ2_Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
        static void Main(string[] args)
        {
            Console.Clear();
            int NumberOfWeek = 0;
            Console.WriteLine("Введите число дня недели: ");
            NumberOfWeek = Convert.ToInt32(Console.ReadLine());
            switch (NumberOfWeek)
            {
                case 1:
                    {
                        Console.WriteLine( "Понедельник - рабочий день");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine( "Вторник - рабочий день");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine( "Среда - рабочий день");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine( "Четверг - рабочий день");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine( "Пятница - рабочий день");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine( "Суббота - выходной день");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine( "Воскресенье - выходной день");
                        break;
                    }
            }
            // Console.Clear();        
            // Console.WriteLine("Введите число дня недели: ");
            // int number = Convert.ToInt32(Console.ReadLine());
            // // int [] array = new int [1, 2, 3, 4, 5, 6, 7];
            // // int [] num = {1, 2, 3, 4, 5, 6, 7};
            // if(number < 6)
            // {
            //     Console.WriteLine($"Рабочий день");
            // }
            // if (number > 5) Console.WriteLine($"Выходной день");
                                
        }
    }
}