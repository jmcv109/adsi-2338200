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

            Console.WriteLine("\n");
            for (int i = 0; i < Vector.Length; i++)
            {
                Console.WriteLine("Ingrese el numero para la posicion #"+(i+1));
                _= double.TryParse(Console.ReadLine(), out double numero);
                
                Vector[i] = numero;   
            }

            string nombre;
            double  suma = 0, promedio = 0;
           
            Console.WriteLine("Escriba nombre del alumno: " );
            nombre  = Console.ReadLine ();

            for (int i=1; i<=7; i++ )
            {
                Console.WriteLine("Digite la calificiacion numero" +i);
                _ = double.TryParse(Console.ReadLine(), out double calificacion);
                suma += calificacion;
                promedio = suma/7;
            }
            Console.WriteLine("El alumno es "+nombre+" y el promedio que obtuvo en la materia Diseño Estructurado de Algoritmos es: " +promedio);
        }
    }
}
