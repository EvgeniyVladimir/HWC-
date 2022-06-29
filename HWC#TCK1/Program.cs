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
            
            if (numbera > numberb) Console.WriteLine($"Больше число: {numbera}");
            
                else Console.WriteLine($"Больше число: {numberb}");
        }
    }
}
