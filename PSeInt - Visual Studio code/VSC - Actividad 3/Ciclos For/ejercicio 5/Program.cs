using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular e imprimir la tabla de multiplicar de un número cualquiera. Imprimir el multiplicando, el
            //multiplicador y el producto.


            Console.WriteLine("\nDigite el numero del cual desea saber la tabla de multiplicar: ");
            _ = double.TryParse(Console.ReadLine(), out double num);

            double resultado=0;
            Console.WriteLine("\nLa tabla de multiplicar del numero " +num+ " es:");

            for (int multiplicador=1; multiplicador<=10; multiplicador++ )
            {
                resultado = num*multiplicador;
                Console.WriteLine(num+" X "+multiplicador+" = " +resultado);
            }
        }
    }
}
