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

            Ordina(vet);

            int min =Minimo(vet);
            Console.WriteLine("il valore minimo è : " + min);


            Console.ReadKey();
        }
        static void Ordina (int[] v)
        {
            Array.Sort(v);
        }
        static int Minimo(int[] v)
        {
            return v[0];
        }
    }
}
