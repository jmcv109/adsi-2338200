using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //7. Una agencia de seguros desea obtener un reporte al final del día de sus n empleados para determinar
            //cuál fue el empleado que obtuvo el mayor sueldo en base a sus ventas y comisiones, se registrará el
            //nombre del empleado la edad y el sueldo que obtuvo al final del día. Desarrollar un programa que
            //pida al usuario el nombre de los n empleados, su edad y el sueldo para generar un reporte que lo
            //muestre en pantalla de la siguiente manera: el nombre del empleado, edad, sueldo, el empleado con
            //mayor sueldo, el sueldo del empleado que gana más y su edad.
            //Debe declarar un arreglo de enteros para la edad.
            //Debe declarar un arreglo de reales para el sueldo.
            //Debe declarar un arreglo de cadena para el nombre

            string[] VectorNombres;
            string nombre;
            int[] VectorEdades;
            double[] VectorSueldo;
            int[] Ventas;
            double SueldoMayor = 0;
            int indice = 0;

            Console.WriteLine("\n");
            Console.WriteLine("Digite la cantidad de empleados que tiene la empresa");
            _ = int.TryParse(Console.ReadLine(), out int CantEmple);
            Console.WriteLine("Digite el valor de la comision por cada venta que hace un empleado");
            _ = double.TryParse(Console.ReadLine(), out double comision);
            Console.WriteLine("\n");

            VectorNombres = new string[CantEmple];
            VectorEdades = new int [CantEmple];
            Ventas = new int [CantEmple];
            VectorSueldo = new double [CantEmple];

            for (int i = 0; i < VectorNombres.Length; i++ )
            {
                Console.WriteLine("Digite el nombre del empleado #"+(i+1));
                nombre = (Console.ReadLine());
                Console.WriteLine("Digite la edad del empelado #"+(i+1));
                _ = int.TryParse(Console.ReadLine(), out int Edad);
                Console.WriteLine("Digite la cantidad de ventas que hizo el empleado #"+(i+1));
                _ = int.TryParse(Console.ReadLine(), out int CantVentas);
                Console.WriteLine("\n");
                VectorNombres[i] = nombre;
                VectorEdades[i] = Edad;
                Ventas[i] = CantVentas;
            }
            for (int i = 0; i < VectorNombres.Length; i++)
            {
                VectorSueldo[i] = Ventas[i] * comision;
                Console.WriteLine("El nombre del empleado #"+(i+1)+" es: "+VectorNombres[i]);
                Console.WriteLine("La edad del empleado #"+(i+1)+" es: "+VectorEdades[i]);
                Console.WriteLine("El sueldo del empleado #"+(i+1)+" es: "+VectorSueldo[i]);
                Console.WriteLine("\n");
            }
            for (int i = 0; i < VectorNombres.Length; i++)
            {
                if (VectorSueldo[i] > SueldoMayor)
                {
                    SueldoMayor = VectorSueldo[i];
                    indice = i;   
                }
            }
            Console.WriteLine("El empleado con MAYOR sueldo es: "+VectorNombres[indice]);
            Console.WriteLine("La edad del empleado con MAYOR sueldo es: "+VectorEdades[indice]);
            Console.WriteLine("El sueldo de este empleado es: "+VectorSueldo[indice]+"\n");    
        }
    }
}
