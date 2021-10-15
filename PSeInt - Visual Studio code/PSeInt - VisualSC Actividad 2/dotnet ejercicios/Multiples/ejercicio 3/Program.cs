using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3. Dados como datos dos variables de tipo entero, obtenga el resultado de la siguiente función:

            Val               Num             
    
            100 * v            1                     
            100^v              2               
            100/v              3               
            0               Cualquier número*/

            int Numero1, Val, resultado;

            Console.WriteLine("Digite la operacion que quiere realizar. \n 1. 100 * V \n 2. 100 ^ V \n 3. 100 / V");
            Numero1 = int.Parse(Console.ReadLine());

            while (Numero1 != 1 && Numero1 != 2 && Numero1 != 3)
            {
                Numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite la operacion que quiere realizar. \n 1. 100 * V \n 2. 100 ^ V \n 3. 100 / V");
            }
            
            Console.WriteLine("Asignelé un Valor a la variable (V)");
            bool resp = int.TryParse(Console.ReadLine(), out Val);
            

            switch (Numero1)
            {
                case 1:
                    resultado = 100 * Val;
                    break;
                case 2:
                    resultado = 100 ^ Val;
                    break;
                case 3:
                    resultado = 100 / Val;
                    break;
                default:
                    Console.WriteLine(" El resultado es 0");
                    break;
                Console.WriteLine("El resultado es " + resultado);
            }

        }
    }
}
