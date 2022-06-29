namespace HelloWorld
{
    class Program
    {
        // ДЗ1 Написать программу, которая на вход принимает два числа и выдает какое число больше, а какое меньше.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a:");
            int numbera = Convert.ToInt32(Console.ReadLine( ));
            Console.WriteLine("Введите число b:");
            int numberb = Convert.ToInt32(Console.ReadLine( ));
            Console.WriteLine("Введите число c:");
            int numberc = Convert.ToInt32(Console.ReadLine( ));
            int max = 0;

            if (numbera > max) max = numbera;
            if (numberb > max) max = numberb;
            if (numberc > max) max = numberc;

            Console.WriteLine($"Максимальное число: {max}");
          }
    }
}
