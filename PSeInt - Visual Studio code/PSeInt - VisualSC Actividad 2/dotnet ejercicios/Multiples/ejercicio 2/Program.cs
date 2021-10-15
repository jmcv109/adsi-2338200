using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void MainTemporal(string[] args)
        {
            /*2. Una compañía de fumigación utiliza aviones para fumigar las cosechas contra una gran variedad de plagas. Las
            cantidades que la compañía cobra a los granjeros depende de qué es lo que se desea fumigar y del número de
            hectáreas que se desea fumigar, de acuerdo con la siguiente distribución :
            Tipo 1 : Fumigación contra malas hierbas, $50 000 por hectárea
            Tipo 2 : Fumigación contra moscas y mosquitos, $70 000 por hectárea
            Tipo 3 : Fumigación contra gusanos, $80 000 por hectárea.
            Tipo 4 : Fumigación contra todo lo anterior, $190 000 por hectárea.
            • Si el área a fumigar es mayor de 100 hectáreas, el granjero goza de un 5% de descuento.
            • Además, si la cuenta total sobrepasa el $1 000 000 se hace acreedor a un 10% de descuento sobre la cantidad
            que sobrepase el $1 000 000.
            • Si ambos descuentos son aplicables, el correspondiente a la superficie se considera primero.
            Diseñe el programa que lea el nombre del granjero, el tipo de fumigación solicitada (1-4) y el número de hectáreas a
            fumigar.
            Se debe imprimir el nombre del granjero y la cuenta total.*/

            int numhectareas, tipo_fumigación;
            string Nombre;
            double valor_total, descuento;

            Console.WriteLine("Nombre del granjero o encargado de la finca:");
            Nombre = Console.ReadLine();
            Console.WriteLine("Numero de hectareas que desea Fumigar:");
            bool resp = double.TryParse(Console.ReadLine(), out Hectareas);
            Console.WriteLine("Tipo de Fumigación \n 1. Fumigación contra malas hierbas \n 2. Fumigación contra moscas y mosquitos \n 3. Fumigación contra gusanos \n 4. Fumigación contra todo lo anterior");
            bool resp = double.TryParse(Console.ReadLine(), out Hectareas);

            switch (tipo_fumigación)
            {
                case 1:
                    valor_total = numhectareas * 50000;
                    break;
                case 2:
                    valor_total = Hectareas * 70000;
                    break;
                case 3:
                    valor_total = Hectareas * 80000;
                    break;
                case 4:
                    valor_total = Hectareas * 190000;
                    break;
                default:
                    Console.WriteLine("no se selecciono una opcion valida para la fumigacion");
                    break;
            }
            if (numhectareas > 100)
            {
                descuento = valor_total * 0.05;
            }
            else if (valor_total > 1000000)
            {
                descuento = (valor_total - 1000000) * 0.10;
            }
            else
            {
                descuento = 0;
            }
            valor_total = valor_total - descuento;

            Console.WriteLine("El granjero que contrata el servicio es: " + Nombre);
            Console.WriteLine("El cvalor total de la fumigacion es: " + valor_total);
        }
    }
}
