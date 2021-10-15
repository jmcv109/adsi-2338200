using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*8. El jefe del departamento de construcción de la constructora Pagasa, desea que se le desarrolle un programa
            en C++ para sus empleados, el cual calcule el sueldo de un empleado, de tal manera que el sueldo se calculará
            de la siguiente manera: si el número de horas trabajadas es mayor a 40, el excedente de 40 hrs. se paga al
            doble de la cuota por hora, en caso de no ser mayor a 40 hrs. se paga la cuota normal por hora, si las horas
            exceden a 50 hrs. el excedente de 50 hrs. se paga al triple de la cuota por hora. Se pedirá el nombre del
            empleado, el número de horas trabajadas y la cuota por hora. mostrar en pantalla el nombre del empleado, el
            número de horas trabajadas y su sueldo.*/

            double sueldo, Valor_Hora, Numero_Hora, Hora_Extra;
            string Nombre;

            Console.WriteLine("Digite su nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Digite el valor de la hora de trabajo");
            Valor_Hora = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el numero de horas que trabajo");
            Numero_Hora = double.Parse(Console.ReadLine());

            if (Numero_Hora <= 40)
            {
                sueldo = Numero_Hora * Valor_Hora;
            }
            else if (Numero_Hora > 40 && Numero_Hora <= 50)
            {
                sueldo = 40 * Valor_Hora;
                HorExtr = (Numero_Hora - 40) * (Valor_Hora * 2);
                sueldo = sueldo + Hora_Extra;
            }
            else if (Numero_Hora > 50)
            {
                sueldoP = (50 * ValHora);
                HorExtr = (NumHora - 50) * (ValHora * 3);
                sueldo = sueldo + Hora_Extra;
            }
            Console.WriteLine(Nombre);
            Console.WriteLine("Esta semana trabajó " + Numero_Hora + "horas");
            Console.WriteLine("Su sueldo es de " + sueldo);

        }
    }
}
