using System;

namespace dotnet_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //8. Un alumno de la clase de lógica matemática desea desarrollar un programa que calcule el factorial
            //de un número N, el cual le dará al usuario, el factorial de un número N, definido matemáticamente
            //como N! se obtiene como la multiplicación de todos los números que están desde el 1 hasta el N = 1
            //* 2 * 3 * ..... (N-2) * (N-1) * N, como se muestra en la figura, por definición el factorial de 0 es 1.

            int num, factorial = 1;

			Console.WriteLine("Ingrese el numero del que quiere saber el factorial");
			_ = int.TryParse(Console.ReadLine(), out num);

			for (int i=num; i>=1; i--)
            {
				Console.WriteLine(i);
				factorial = factorial * i; 
            }
			if (num == 0)
            {
				factorial = 1;
            }
			Console.WriteLine("El factorial del número " + num + " es " + factorial);
        }
    }
}
