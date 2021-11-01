using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leer 20 números e imprimir cuantos son positivos, cuantos negativos y cuantos cero.
            double cantidadP = 0, cantidadN = 0, cantidadC = 0; 
            for (int i=1; i<=20; i++ )
            {
                Console.WriteLine("Digite el numero " +i);
                _ = double.TryParse(Console.ReadLine(), out double num);

                if (num > 0)
                    {
                        cantidadP = cantidadP + 1;
                    }
                    else if (num < 0)
                    {
                        cantidadN = cantidadN + 1;
                    }
                    else
                    {
                        cantidadC = cantidadC + 1;
                    }
            }
            Console.WriteLine("Hay "+cantidadP+" numeros positivos");
            Console.WriteLine("Hay "+cantidadN+" numeros negativos");
            Console.WriteLine("Hay "+cantidadC+" numeros 0");
        }
    }
}
