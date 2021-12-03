using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //7. Al cerrar un expendio de naranjas, 15 clientes recibirán un 15% de descuento si compran más de 10
            //kilos. Determinar cuánto pagará cada cliente y cuanto percibirá la tienda por esas compras.

            Console.WriteLine("Digite el valor por kilo de naranjas");
            _ = double.TryParse(Console.ReadLine(), out double valorK);

            double descuento = 0, pagototal = 0, pago = 0, sumapagos = 0;

            for (int i=1; i<=5; i++)
            {
                Console.WriteLine("Digite el numero de kilos de naranja que compro el cliente #"+i);
                _ = double.TryParse(Console.ReadLine(), out double kilos);

                pago=valorK*kilos;
                if (kilos > 10)
                    {
                        descuento = pago*0.15;
                    }
                else
                    {
                        descuento = 0;
                    }
                pagototal = pago-descuento;
                sumapagos = sumapagos + pagototal;
                Console.WriteLine("El cliente #"+i+" debe pagar "+pagototal);
            }
            Console.WriteLine("Las ganancias de la empresa fueron "+sumapagos);
        }
    }
}
