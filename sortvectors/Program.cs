using System;

namespace sortvectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10] { 4, 6, 7, 8, 9, 0, 1, 2, 1, 45 };
            for (int i = 0; i < 10; i++)
                Console.WriteLine(vet[i]);

            Console.ReadKey();
        }
    }
}
