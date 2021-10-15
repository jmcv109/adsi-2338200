using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void MainTemporal(string[] args)
        {
            /*7. Leer 2 números; si son iguales que los multiplique, si el primero es mayor que el segundo que los reste y si no
            que los sume.*/

            double numero1, numero2, resultado;

            Console.WriteLine("Digite el primer numero");
            numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            numero2 = double.Parse(Console.ReadLine());

            if (numero1 == numero2)
            {
                resultado = numero1 * numero2;
            }
            else if (numero1 > numero2)
            {
                resultado = numero1 - numero2;
            }
            else
            {
                resultado = numero1 + numero2;
            }
            Console.WriteLine("El resultado es " + resultado);

        }
    }
}
