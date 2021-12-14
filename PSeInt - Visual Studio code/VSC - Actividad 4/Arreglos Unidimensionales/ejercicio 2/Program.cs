using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Llenar dos vectores A y B de 10 elementos cada uno, sumar el elemento uno del vector A con el
            //elemento uno del vector B y así sucesivamente hasta 10, almacenar el resultado en un vector C, e
            //imprimir el vector resultante.

            double[] VectorA = new double [4];
            double[] VectorB = new double [VectorA.Length];
            double[] VectorC = new double [VectorB.Length];

            Console.WriteLine("\nElementos del Vector A");
            for (int i = 0; i < VectorA.Length; i++)
            {
                Console.WriteLine("Ingrese el valor del elemento "+(i+1));
                _= double.TryParse(Console.ReadLine(), out double element);
                
                VectorA[i] = element;   
            }

            Console.WriteLine("\nElementos del Vector B");
            for (int i = 0; i < VectorB.Length; i++)
            {
                Console.WriteLine("Ingrese el valor del elemento "+(i+1));
                _= double.TryParse(Console.ReadLine(), out VectorB[i]);  
            }

            Console.WriteLine("\nElementos del Vector C ");
            for (int i = 0; i < VectorA.Length; i++)
            {
                VectorC[i] = VectorA[i] + VectorB[i];
                Console.WriteLine("La suma de "+VectorA[i]+" + "+VectorB[i]+" es: "+VectorC[i]);
            }
        }
    }
}
