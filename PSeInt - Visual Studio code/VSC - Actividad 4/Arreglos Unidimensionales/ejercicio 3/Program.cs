using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Almacenar 15 números en un vector, imprimir cuantos son ceros, cuántos son negativos, cuantos
            //positivos. Imprimir además la suma de los negativos, la suma de los ceros y la suma de los positivos.

            double[] VectorN = new double [15];
            double sumaP = 0, sumaN = 0, sumaC = 0, positivos = 0, negativos = 0, ceros = 0;

            Console.WriteLine("\n ");
            for (int i = 0; i < VectorN.Length; i++)
            {
                Console.WriteLine("Ingrese el numero para la casilla "+(i+1));
                _= double.TryParse(Console.ReadLine(), out double numero);
                
                VectorN[i] = numero;   
            }

            for (int i = 0; i < VectorN.Length; i++)
            {
                if (VectorN[i] > 0)
                {
                    sumaP += VectorN[i]; 
                    positivos++;
                }
                else if (VectorN[i] < 0)
                {
                    sumaN += VectorN[i];
                    negativos++;
                }
                else
                {
                    sumaC += VectorN[i];
                    ceros++;
                }
            }
            Console.WriteLine("\nLa cantidad de numeros positivos que hay en este vector es de: "+positivos);
            Console.WriteLine("La cantidad de numeros negativos que hay en este vector es de: "+negativos);
            Console.WriteLine("La cantidad de numeros con valor cero que hay en este vector es de: "+ceros);

            Console.WriteLine("\nLa suma de los numeros positivos es de: "+sumaP);
            Console.WriteLine("La resta numeros negativos es de: "+sumaN);
            Console.WriteLine("La suma de los numeros con valor cero es de: "+sumaC);
            Console.WriteLine("\n");


        }
    }
}
