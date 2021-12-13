using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Calcular el promedio de 50 valores almacenados en un vector. Determinar además cuantos son
            //mayores que el promedio, imprimir el promedio, el número de datos mayores que el promedio y una
            //lista de valores mayores que el promedio.

            double[] VectorValores = new double [50];
            double NumerosMayores = 0, promedio = 0, suma = 0;

            for (int i = 0; i < VectorValores.Length; i++)
            {
                Console.WriteLine("\nIngrese el valor para la posicion "+(i+1)+" :");
                _= double.TryParse(Console.ReadLine(), out double Valor);

                VectorValores[i] = Valor;
                suma += Valor;   
            }
            promedio = suma / VectorValores.Length;

            Console.WriteLine("\nEl promedio de los 50 valores es de: "+promedio+"\n");

            for (int i = 0; i < VectorValores.Length; i++)
            {
                if (VectorValores[i] > promedio)
                {
                    NumerosMayores++;  
                    Console.WriteLine("El valor "+VectorValores[i]+" es mayor que el promedio");
                }
            }
            Console.WriteLine("\nLa cantidad de numeros mayores a el promedio es de: "+NumerosMayores+"\n"); 
        }
    }
}
