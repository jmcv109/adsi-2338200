using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Diseñe un algoritmo que lea un número cualquiera y lo busque en el vector X, el cual tiene
            //almacenados 12 elementos. Escribir la posición donde se encuentra almacenado el número en el
            //vector o el mensaje “NO” si no lo encuentra.

            bool verificacion= false;
            double[] VectorX = {9, 10, 19, 22, 24, 34, 35, 45, 50, 69, 77, 80};

            Console.WriteLine("\n¿Que numero quiere buscar en el Vector X? ");
            _= double.TryParse(Console.ReadLine(), out double numero);
            for (int i = 0; i < VectorX.Length; i++)
            {
                if(VectorX[i] == numero )
                {
                Console.WriteLine("\nEl numero se encuentra en la posicion "+(i+1));
                verificacion = true;
                }    
            }
            if (verificacion == false)
            {
                Console.WriteLine("\nEl numero no se encontro en el Vector X");
            }
            Console.WriteLine("\n");
        }
    }
}
