using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void MainTemporal(string[] args)
        {
            /*3. Hacer un algoritmo que calcule el total a pagar por la compra de camisas. Si se compran tres camisas o mas se
            aplica un descuento del 20% sobre el total de la compra y si son menos de tres camisas un descuento del 10%*/

            double PrecioUnidad, total_pago;
            byte Cantidad_Camisas;

            Console.WriteLine("Digite el valor por unidad de las camisas");
            PrecioUnidad = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad de camisas que va a comprar");
            Cantidad_Camisas = byte.Parse(Console.ReadLine());

            total_pago = (Cantidad_Camisas * PrecioUnidad);

            if (Cantidad_Camisas >= 3)
            {
                total_pago = total_pago - (total_pago * 0.20); 
            }
            else
            {
                total_pago = total_pago - (total_pago * 0.10);
            }

            Console.WriteLine("El total del pago es " + total_pagar);

        }
    }
}
