using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Dado tres números calcular el mayor*/

            double numero1, numero2, numero3;

            Console.WriteLine("Digite el primer numero");
            numero1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            numero2 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Digite el tecer numero");
            numero3 = byte.Parse(Console.ReadLine());

            if (numero1 > numero2 && numero1 > numero3)
            {
                Console.WriteLine("El número mayor es " + numero1);
            }
            else if(numero2 > numero1 && numero2 > numero3)
            {
                Console.WriteLine("El número mayor es " + numero2);
            }
            else 
            {
                Console.WriteLine("El número mayor es " + numero3);
            }

        }
    }
}
