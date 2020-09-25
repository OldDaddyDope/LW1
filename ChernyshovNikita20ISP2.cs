using System;

namespace dz
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double P, x, y, c, a;
                Console.Write("Введите x:");
                x = double.Parse(Console.ReadLine());
                Console.Write("Введите y:");
                y = double.Parse(Console.ReadLine());
                Console.Write("Введите c:");
                c = double.Parse(Console.ReadLine());
                Console.Write("Введите a:");
                a = double.Parse(Console.ReadLine());
                P = (Math.Pow(a, 5) + Math.Acos(a + Math.Pow(x, 3)) - Math.Pow(Math.Sin(y - c), 4)) / (Math.Pow(Math.Sin(x + y), 3) + Math.Abs(x - y)); 
                Console.WriteLine("P=" + P);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}

