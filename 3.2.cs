using System;

namespace proizvedenie_kubov
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Arr = { 1, 2, 3 };
            int Pow = 3;

            double Multiply = 1;

            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine($"Куб числа {Arr[i]} = {Math.Pow(Arr[i], Pow)}");
                Multiply *= Math.Pow(Arr[i], Pow);
            }
            Console.WriteLine($"Произведение кубов чисел = {Multiply}");
        }
    }
}
