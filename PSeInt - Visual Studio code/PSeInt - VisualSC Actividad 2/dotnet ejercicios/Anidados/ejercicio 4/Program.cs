using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. En un montallantas se ha establecido una promoción de las llantas marca “Ponchadas”, dicha promoción
            consiste en lo siguiente:
            Si se compran menos de cinco llantas el precio es de $90000 cada una, de $80000 si se compran de cinco a 10
            y de $70000 si se compran más de 10. Obtener la cantidad de dinero que una persona tiene que pagar por cada
            una de las llantas que compra y la que tiene que pagar por el total de la compra*/

            byte Cantidad;
            double Total_Pago;

            Console.WriteLine("Digite la cantidad de llantas Ponchadas que va a comprar");
            Cantidad = byte.Parse(Console.ReadLine());

            if (Cantidad > 0 && Cantidad < 5)
            {
                Total_Pago = Cantidad * 90000;
                valor_llanta = 90000;
            }
            else if (Cantidad => 5 && Cantidad <= 10)
            {
                TotPag = Cantidad * 80000;
                valor_llanta = 80000;
            }
            else if (Cantidad > 10)
            {
                TotPag = Cantidad * 70000;
                valor_llanta = 70000;
            }
            Console.WriteLine("Cada llanta le cuesta" + valor_llanta + " y su total a pagar es de " + Total_Pago);

        }
    }
}
