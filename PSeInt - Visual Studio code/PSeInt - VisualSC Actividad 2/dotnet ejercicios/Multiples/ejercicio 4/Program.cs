using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. Calcular el valor de f(x) según la expresión
             *       
                            x ^ 2               Si x mod 4 = 0
                            x / 6               Si x mod 4 = 1
                      f(x)  Raiz(x)             Si x mod 4 = 2
                            X ^ 3 + 5           Si x mod 4 = 3*/



            double  Operación, mood;
            byte x;
            
            Console.WriteLine("Asignelé un valor a 'X':");
            x = byte.Parse(Console.ReadLine());

            mood = x % 4;
            
            
                switch (mood)
                {
                    case 0:
                        Operación = x ^ 2;
                        Console.WriteLine("La operacion fue:");
                        Console.WriteLine(x + " ^ 2 = " + Operación);
                        break;
                    case 1:
                        Operación = x / 6;
                        Console.WriteLine("La operacion fue:");
                        Console.WriteLine(x + " / 6 = " + Operación);
                        break;
                    case 2:
                        Operación = Math.Sqrt(x);
                        Console.WriteLine("La operacion fue:");
                        Console.WriteLine(" Raiz(" + x + ") = " + Operación);
                        break;
                    case 3:
                        Operación = x ^ 3 + 5;
                        Console.WriteLine("La operacion fue:");
                        Console.WriteLine(x + " ^ 3 + 5  = " + Operación);
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }

        }
    }
}
