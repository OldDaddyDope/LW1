using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double R, r, n, a;
                Console.Write("Введите число сторон n:");
                n = double.Parse(Console.ReadLine());
                Console.Write("Введите длину сторон a:");
                a = double.Parse(Console.ReadLine());
                R = a / 2 * Math.Sin(Math.PI / n);
                r = a / 2 * Math.Tan(Math.PI / n);
                Console.Write("Радиус описанной окружности R:{0:F2}", R);
                Console.Write("Радиус вписанной окружности r:{0:F2}", r);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
