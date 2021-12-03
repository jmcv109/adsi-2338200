using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //7. Encontrar el menor valor de un conjunto de n números dados.
            Console.WriteLine(" Digite la cantidad de numeros que desea utilizar en este programa: ");
            _ = int.TryParse(Console.ReadLine(), out int n);
            int contador = 0;
            double nummenor = 0;

            while (contador < n)
            {
                Console.WriteLine(" Digite un numero: ");
                _ = int.TryParse(Console.ReadLine(), out int Num);

                if (contador == 1)
                {
                    nummenor = Num;

                }
                else if (Num < nummenor)
                {
                    nummenor = Num;
                }
                contador++;
              
            }           
            Console.WriteLine("\nEl numero menor es"+nummenor );

        }
    }
}
