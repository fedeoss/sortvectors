using System;

namespace sortvectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10] { 4, 6, 7, 8, 9, 0, 1, 2, 1, 45 };

            Ordina(vet);


            int massimo = Massimo(vet);

            Console.WriteLine("Il valore massimo è: " + massimo);


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(vet[i]);
            }
                
            

            Console.ReadKey();


        }
        static void Ordina(int [] v)
        {
            Array.Sort(v);
        }

        static int Massimo(int[] v)
        {
            return v[9];
        }

    }
}
