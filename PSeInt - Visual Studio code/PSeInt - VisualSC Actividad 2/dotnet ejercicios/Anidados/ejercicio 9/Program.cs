using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*9. El fondo de administración de pensiones requiere clasificar a las personas que se jubilaran en el año 2009.
            Existen tres tipos de jubilaciones: por edad, por antigüedad joven y por antigüedad adulta. Las personas
            adscritas a la jubilación por edad deben tener 60 años o mas y una antigüedad en su empleo de menos de 25
            años.
            Las personas adscritas a la jubilación por antigüedad joven deben tener menos de 60 años y una antigüedad
            en su empleo de 25 años o más.
            Las personas adscritas a la jubilación por antigüedad adulta deben tener 60 años o mas y una antigüedad en su
            empleo de 25 años o mas.
            Determinar en que tipo de jubilación, quedara adscrita una persona.*/

            byte edad, Antigüedad;
            string Nombre, tipo_jubilacion;

            Console.WriteLine("Digite el nombre de la persona que accedera a la jubilacion");
            Nombre = Console.ReadLine();
            Console.WriteLine("Digite la edad en años de " + Nombre);
            edad = byte.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad de años que trabajo " + Nombre);
            Antigüedad = byte.Parse(Console.ReadLine());

            if (Antigüedad >= 25 )
            {
                if (Edad < 60)
                {
                    tipo_jubilacion = " Por Antigüedad Joven";
                }
                else
                {
                    TipJub = " Por Antigüedad Adulta";
                }
            }
            else if (Edad >= 60)
            {
                tipo_jubilacion = "Por edad ";
            }
            Console.WriteLine(Nombre + " Esta clasificado " + tipo_jubilacion);

        }
    }
}
