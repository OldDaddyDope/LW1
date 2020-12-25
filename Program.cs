using System;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите x:");
                uint x = uint.Parse(Console.ReadLine());
                if (x > 3 || x < -1) Console.WriteLine("выражение истинно");
                else Console.WriteLine("выражение неистенно");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
