using System;

namespace Numeros_primos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("|                  Números primos                |");
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("Escreva um número: ");
            int numberEntrance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"O número: {numberEntrance} é primo? {isPrimeNumber(numberEntrance)}");
            functiones();
        }

        static bool isPrimeNumber(int primeNumberTeste)
        {
            bool PrimeK = true;

            for (int i = 2; i < primeNumberTeste / 2; i++)
            {
                if (primeNumberTeste % i == 0)
                {
                    PrimeK = false;
                }
            }
            return PrimeK;

        }

        static void functiones()
        {
            int X = 20, Y = 10;
            X = X ^ X / Y % 2;
            Console.WriteLine(X);
        }
    }
}
