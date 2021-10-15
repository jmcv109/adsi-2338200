using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2. Dado el monto de una compra calcular el descuento considerado
            Descuento es 20% si el monto es mayor a 20 000 pesos.
            Descuento es 10% si el monto es mayor a 10 000 pesos y menor o igual a 20000 pesos.
            no hay descuento si el monto es menor o igual a 10000 pesos.*/

            double Valor_Compra, descuento_Compra, Total_Pago;

            Console.WriteLine("Digite el valor total de su compra");
            Valor_Compra = double.Parse(Console.ReadLine());

            if(Valor_Compra > 10000)
            {
                descuento_Compra = (Valor_Compra * 0.10);
            }
            else if (Valor_Compra > 20000 )
            {
                descuento_Compra = (Valor_Compra * 0.10);
            }
            else 
            {
                descuento_Compra = 0;
            }

            Total_Pago = Valor_Compra - descuento_Compra;

            Console.WriteLine("El valor total a pagar es de " + Total_Pago);

        }
    }
}
