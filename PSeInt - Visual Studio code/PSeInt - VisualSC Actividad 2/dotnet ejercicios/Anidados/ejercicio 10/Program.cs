using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*10. Tomando como base los resultados obtenidos en un laboratorio de análisis clínicos, un medico determina si
             una persona esta normal, tiene anemia o tiene cardiopatía lo cual depende de su nivel de hemoglobina en la
             sangre, de su edad y de su sexo. Si el nivel de hemoglobina que tiene una persona es menor que el rango que
             le corresponde, se determina su resultado como Anemia, si esta dentro del rango, se determina su resultado
             como Normal y si esta por encima del rango, se determina su resultado como Cardiopatía. La tabla en la que el
             medico se basa para obtener el resultado es la siguiente:
             EDAD                   NIVEL HEMOGLOBINA 
             0 - 1 mes              13 - 26 g%        
             > 1 y < = 6 meses      10 - 18 g%        
             > 6 y < = 12 meses     11 - 15 g%        
             > 1 y < = 5 años       11.5 - 15 g%      
             > 5 y < = 10 años      12.6 - 15.5 g%    
             > 10 y < = 15 años     13 - 15.5 g%      
                                                     
            
            mujeres > 15 años 12 - 16 g%              

            hombres > 15 años 14 - 18 g%              */

            string  nombre;
            byte hemoglobina, sexo, menor;
            double edad;

            Console.WriteLine("Digite el nombre del paciente");
            nombre = Console.ReadLine();
            Console.WriteLine("Digite el sexo del paciente\n 1. Mujer\n 2. Hombre");
            sexo = byte.Parse(Console.ReadLine());
            while(sexo != 1 && sexo != 2)
            {
                Console.WriteLine("Opción Incorrecta");
                Console.WriteLine("Digite el sexo del paciente\n 1. Mujer\n 2. Hombre");
                sexo = byte.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite el nivel de Hemoglobina en la sangre del paciente (g%)");
            hemoglobina = byte.Parse(Console.ReadLine());
            Console.WriteLine("Digite la edad del paciente en años, en caso que el paciente sea menor de un año, digite 20");
            edad = double.Parse(Console.ReadLine());

            /*Meses del bebé*/

            if (edad == 20) 
            {
                Console.WriteLine("Digite los meses del menor");
                menor = byte.Parse(Console.ReadLine());
                if (menor <= 1)
                {
                    if (hemoglobina >= 13 && hemoglobina <= 26)
                    {
                        Console.WriteLine("El diagnostico del paciente es normal");
                    }
                    else if (hemoglobina < 13)
                    {
                        Console.WriteLine("El paciente sufre de anemia");
                    }
                    else
                    {
                        Console.WriteLine("El paciente sufre de Cardiopatia");
                    }
                }
                else if (menor > 1 && menor <= 6)
                {
                    if (hemoglobina >= 10 && hemoglobina <= 18)
                    {
                        Console.WriteLine("El diagnostico del paciente es normal");
                    }
                    else if (hemoglobina < 10)
                    {
                        Console.WriteLine("El paciente sufre de anemia");
                    }
                    else
                    {
                        Console.WriteLine("El paciente sufre de Cardiopatia");

                    }
                }
                else if (menor > 6 && menor <= 12)
                {
                    if (hemoglobina >= 11 && hemoglobina <= 15)
                    {
                        Console.WriteLine("El diagnostico del paciente es normal");
                    }
                    else if (hemoglobina < 11)
                    {
                        Console.WriteLine("El paciente sufre de anemia");
                    }
                    else
                    {
                        Console.WriteLine("El paciente sufre de Cardiopatia");
                    }

                }
            }
            /*Años de 1 a 5*/
            else if (edad > 1 && edad <= 5 )
            {
                if (hemoglobina >= 11.5 && hemoglobina <= 15 )
                {
                    Console.WriteLine("El diagnostico del paciente es normal");
                }
                else if (hemoglobina < 11.5)
                {
                    Console.WriteLine("El paciente sufre de anemia");
                }
                else
                {
                    Console.WriteLine("El paciente sufre de Cardiopatia");
                }
            }
            /*Años de 5 a 10*/
            else if (edad > 5 && edad <= 10)
            {
                if (hemoglobina >= 12.6 && hemoglobina <= 15.5)
                {
                    Console.WriteLine("El diagnostico del paciente es normal");
                }
                else if (hemoglobina < 12.6)
                {
                    Console.WriteLine("El paciente sufre de anemia");
                }
                else
                {
                    Console.WriteLine("El paciente sufre de Cardiopatia");
                }
            }
            /*Años 10 a 15*/
            else if (edad > 10 && edad <= 15)
            {
                if (hemoglobina >= 13 && hemoglobina <= 15.5)
                {
                    Console.WriteLine("El diagnostico del paciente es normal");
                }
                else if ( hemoglobina < 13 )
                {
                    Console.WriteLine("El paciente sufre de anemia");
                }
                else
                {
                    Console.WriteLine("El paciente sufre de Cardiopatia");
                }
            }
            /*Mayor 15 años*/
            else 
            {
                if (sexo == 1)
                {
                    if (hemoglobina >= 13 && hemoglobina <= 15.5)
                    {
                        Console.WriteLine("El diagnostico del paciente es normal");
                    }
                    else if (hemoglobina < 13)
                    {
                        Console.WriteLine("El paciente sufre de anemia");
                    }
                    else
                    {
                        Console.WriteLine("El paciente sufre de Cardiopatia");
                    }
                }
                else if (sexo == 2)
                {
                    if (hemoglobina >= 13 && hemoglobina <= 15.5)
                    {
                        Console.WriteLine("El diagnostico del paciente es normal");
                    }
                    else if (hemoglobina < 13)
                    {
                        Console.WriteLine("El paciente sufre de anemia");
                    }
                    else
                    {
                        Console.WriteLine("El paciente sufre de Cardiopatia");
                    }
                }
                else
                {
                    Console.WriteLine("Syntax Error");
                }
            }
        }
    }
}
