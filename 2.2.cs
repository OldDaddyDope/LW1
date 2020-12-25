using System;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите текущий час:");
                uint x = uint.Parse(Console.ReadLine());
                if (x >= 0 && x <= 12) Console.WriteLine(x + "am");
                 if (x >= 13 && x <= 24) Console.WriteLine(x-12 + "pm");                   
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
