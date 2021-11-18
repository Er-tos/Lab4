using System;

namespace LoopFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N > 0:");
            int N = Convert.ToInt32(Console.ReadLine());
            int S = 0;
            for (int i = 1; i <= 2 * N - 1; i = i + 2)
            {
                S = S + i;
                Console.WriteLine(S);
            }
            Console.ReadKey();
        }
    }
}
