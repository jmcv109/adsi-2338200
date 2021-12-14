using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //6. Diseñe un algoritmo que lea dos vectores A y B de 7 elementos cada uno y multiplique el primer
            //elemento de A con el último elemento de B y luego el segundo elemento de A por el sexto elemento
            //de B y así sucesivamente hasta llegar al séptimo elemento de A por el primer elemento de B. El
            //resultado de la multiplicación almacenarlo en un vector C. Mostrar el resultado.

            double[] VectorA = new double [7];
            double[] VectorB = new double [VectorA.Length];
            double[] VectorC = new double [VectorB.Length];

            Console.WriteLine("\nElementos del Vector A ");
            for (int i = 0; i < VectorA.Length; i++)
            {
                Console.WriteLine("Ingrese un numero para la posicion #"+(i+1));
                _= double.TryParse(Console.ReadLine(), out double num);
                
                VectorA[i] = num;   
            }

            Console.WriteLine("\nElementos del Vector B");
            for (int i = 0; i < VectorB.Length; i++)
            {
                Console.WriteLine("Ingrese un numero para la posicion #"+(i+1));
                _= double.TryParse(Console.ReadLine(), out VectorB[i]);
                  
            }

            Console.WriteLine("\nElementos del Vector C");
            for (int i = 0, k = VectorB.Length-1; i < VectorA.Length; i++, k--)
            {
                VectorC[i] = VectorA[i] * VectorB[k];
                Console.WriteLine("La multiplicacion de "+VectorA[i]+" * "+VectorB[k]+" es: "+VectorC[i]);
            }
            Console.WriteLine("\n");
        }
    }
}
