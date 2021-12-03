using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //8. Encontrar el mayor valor de un conjunto de n números dados.

            Console.WriteLine("Digite la cantidad de numeros que quiere utilizar en el programa ");
            _ = double.TryParse(Console.ReadLine(), out double n);
            
            int contador = 0;
            double nummayor = 0;

            while (contador < n )
            {
                Console.WriteLine("Digite un numero ");
                _ = double.TryParse(Console.ReadLine(), out double num);
                
                if (contador==1)
                {
                    nummayor = num;
                }
                else if (num>nummayor)
                {
                    nummayor = num;
                }
                contador++;
            }
            Console.WriteLine("El numero mayor " +nummayor);
        } 
    }
}
