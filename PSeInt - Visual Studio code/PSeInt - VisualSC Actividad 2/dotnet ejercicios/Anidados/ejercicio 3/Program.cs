using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void MainTemporal(string[] args)
        {
            /*3. En una fábrica de computadoras se planea ofrecer a los clientes un descuento que dependerá del número de
            computadoras que compre. Si las computadoras son menos de cinco se les dará un 10% de descuento sobre el
            total de la compra; si el número de computadoras es mayor o igual a cinco pero menos de diez se le otorga un
            20% de descuento; y si son 10 o más se les da un 40% de descuento. El precio de cada computadora es de
            $1 100 000*/

            double  Total_Pago, Descuento, Precio_Computador, valor_compra;
            byte Cantidad_Computadores;


            Console.WriteLine("Digite la cantidad de computadores desea comprar");
            CanComp = byte.Parse(Console.ReadLine());

            Precio_Computador = 1100000;

            valor_compra = Cantidad_Computadores * Precio_Computador;

            if (Cantidad_Computadores < 5)
            {
                Descuento = (valor_compra * 0.10);
            }
            else if (Cantidad_Computadores < 10)
            {
                Descuento = (valor_compra * 0.20);
            }
            else 
            {
                Descuento = (valor_compra * 0.40);
            }

            Total_Pago = valor_compra - Descuento;
            Console.WriteLine("Su total a pagar es de " + Total_Pago);

        }
    }
}
