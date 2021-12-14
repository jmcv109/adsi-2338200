using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Almacenar 8 números en un vector, almacenarlos en otro vector en orden inverso al vector original
            //e imprimir el vector resultante.

            double[] Vector = new double [8];
            double[] VectorB = new double [8];

            Console.WriteLine("\n");
            for (int i = 0; i < Vector.Length; i++)
            {
                Console.WriteLine("Ingrese el numero para la posicion #"+(i+1));
                _= double.TryParse(Console.ReadLine(), out double numero);
                
                Vector[i] = numero;   
            }
            Console.WriteLine("\nNumeros en el orden original ");
            for (int i = 0; i < Vector.Length; i++)
            {
                Console.WriteLine(Vector[i]); 
            }
            Console.WriteLine("\nNumeros en el orden inverso");
            for (int k = VectorB.Length-1; k < Vector.Length; k--)
            {
                Console.WriteLine(Vector[k]); 
            }
            Console.WriteLine("\n");
            

            
        }
    }
}
