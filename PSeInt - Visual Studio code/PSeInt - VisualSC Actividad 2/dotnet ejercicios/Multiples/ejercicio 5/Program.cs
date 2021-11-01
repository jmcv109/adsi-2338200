using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5. El costo de las llamadas internacionales depende de la zona geográfica en la que se encuentre el país destino,
            y del número de minutos hablados.
            En la siguiente tabla se presenta el costo por minuto por zona. A cada uno se le ha asociado una clave.
             
            Clave           Zona               Precio    
            12              América del Norte   200      
            15              América Central     220      
            18              América del Sur     450      
            19              Europa              350      
            23              Asia                600      
            25              África              600      
            29              Oceanía             500      
        
            Construya la solución para calcular e imprimir el costo de una llamada dada la clave*/


            double Precio_Minutos, Zona, valor_Total, numero;
            int Minutos_Hablados;
            string nombre_caso;

            Console.WriteLine("Digite la extensión de la zona del mundo a la que quiere llamar \n 12. América del Norte \n 15. América Central \n 18. América del Sur \n 19. Europa \n 23. Asia \n 25. África \n 29. Oceanía");
            Zona = double.Parse(Console.ReadLine());

            while (Zona != 12 && Zona != 15 && Zona != 18 && Zona != 19 && Zona != 23 && Zona != 25 && Zona != 29)
            {
                ("Digite la extensión de la zona del mundo a la que quiere llamar \n 12. América del Norte \n 15. América Central \n 18. América del Sur \n 19. Europa \n 23. Asia \n 25. África \n 29. Oceanía");
                Zona = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite el numero al cual desea llamar");
            numero = double.Parse(Console.ReadLine());

            Console.WriteLine("llamando al " + Zona + "-" + numero);
            Console.WriteLine("Digite el numero de minutos que habló");
            Minutos_Hablados = int.Parse(Console.ReadLine());

            switch (Zona)
            {
                case 12:
                    nombre_caso = "America del Norte";
                    Precio_Minutos = 200;
                    break;
                case 15:
                    nombre_caso = "America Central";
                    Precio_Minutos = 220;
                    break;
                case 18:
                    nombre_caso = "America del Sur";
                    Precio_Minutos = 450;
                    break;
                case 19:
                    nombre_caso = "Europa";
                    Precio_Minutos = 350;
                    break;
                case 23:
                    nombre_caso = "Asia";
                    Precio_Minutos = 600;
                    break;
                case 25:
                    nombre_caso = "África";
                    Precio_Minutos = 600;
                    break;
                case 29:
                    nombre_caso = "Oceanía";
                    Precio_Minutos = 500;
                    break;
                valor_Total = Precio_Minutos * Minutos_Hablados;
                Console.WriteLine("Llamada a " + nombre_caso);
                Console.WriteLine("Numero llamadó " + numero );
                Console.WriteLine("Costo total de la llamada " + valor_Total);
                default:
                    Console.WriteLine("Error");
                    break;
            }

        }
    }
}
