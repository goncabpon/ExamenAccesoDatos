using System;

public class Ejercicio2a
{
	public Class1()
	{
        var a = new int[] { 1, 2, 3 };
        var b = new int[] { 1, 2 };

        var result = a.Except(b);
        foreach (int numero in result)
        {
            Console.WriteLine(numero);
            Console.ReadLine();
        }

    }
}
