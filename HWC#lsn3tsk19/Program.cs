// // Задача 19

// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да

namespace NomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите пятизначное число: ");
            string? num = Console.ReadLine();
            char[] a = num.ToCharArray();
            // if(a.Length >= 4)
            //   {
            //     Console.WriteLine("Введите пятизначное число:");
            //   }
                
            if (a[0] == a[4] && a[1] == a[3])
              {
                Console.WriteLine("Это палиндром");
              }
            else
              {
                Console.WriteLine("Это не палиндром");
              }
                
        }
    }
}
