using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Desarrollar un algoritmo que lea dos números y los imprima en forma ascendente.*/

            double Numero1, Numero2;

            Console.WriteLine("Digite el primer numero");
            Numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            Numero2 = double.Parse(Console.ReadLine());

            if (Numero1 < Numero2)
            {
                Console.WriteLine("");
                Console.WriteLine(Numero1);
                Console.WriteLine(Numero2);
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine(Numero2);
                Console.WriteLine(Numero1);
            }

        }
    }
}
