// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53  //Console.Clear();

namespace NomeWorkTask21
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите координаты первой точки xa, ya, za");
            int xa = Convert.ToInt32(Console.ReadLine());
            int ya = Convert.ToInt32(Console.ReadLine());
            int za = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Введите координаты второй точки xb, yb, zb");
            int xb = Convert.ToInt32(Console.ReadLine());
            int yb = Convert.ToInt32(Console.ReadLine());
            int zb = Convert.ToInt32(Console.ReadLine());

            // double len = Math.Sqrt(((xb - xa), 2) + ((yb - ya), 2) + ((zb - za), 2));
            int len = (xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za);
            double dist = Math.Sqrt(len);
            Console.WriteLine(dist);

        }
    }
}
