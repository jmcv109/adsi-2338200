using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5. Una frutería ofrece las manzanas con descuento según la siguiente tabla:
            NUM. DE KILOS COMPRADOS % DESCUENTO
            0 - 2 ------------->0
            2.01 - 5 ---------->10
            5.01 - 10 --------> 15
            10.01 en adelante ->20
            Determinar cuanto pagara una persona que compre manzanas es esa frutería sabiendo que el kilo vale $1300*/

            double total_Pago, kilos;

            Console.WriteLine("Digite la cantidad de kilos de manzanas que quiere comprar ");
            kilos = double.Parse(Console.ReadLine());

            if (kilos > 0 && kilos <= 2)
            {
                total_Pago = 1300 * kilos;
            }
            else if (kilos >= 2.01 && kilos <= 5)
            {
                total_Pago = 1300 * kilos * 0.10;
            }
            else if (kilos >= 5.01 || kilos <= 10)
            {
                total_Pago = 1300 * kilos * 0.15;
            }
            else if (kilos > 10)
            {
                total_Pago = 1300 * kilos * 0.20;
            }
            Console.WriteLine("El pago que debe realizar es de " + total_Pago);

        }
    }
}
