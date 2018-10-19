using System;

public class Ejercicio3
{
	public Class1()
	{
        int[] secuencia = new int[] { 12, 4, 11, 33, 45, 67, 97, 1, 8, 156 };
        for (int numero = 0; numero < secuencia.Length; numero++)
        {
            if (secuencia[numero] % 2 == 0)
            {
                Console.WriteLine(secuencia[numero]);
            }

        }
        Console.WriteLine();
        for (int numero = 0; numero < secuencia.Length; numero++)
        {
            if (secuencia[numero] < 10)
            {
                Console.WriteLine(secuencia[numero]);
            }
        }

        Console.WriteLine();

        for (int numero = 0; numero < secuencia.Length; numero++)
        {
            if (secuencia[numero] > 10)
            {
                Console.WriteLine(secuencia[numero]);
            }
        }
        Console.WriteLine();
        Console.Readline();

    }
}
