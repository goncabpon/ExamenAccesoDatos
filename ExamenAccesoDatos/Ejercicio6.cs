using System;

public class Ejercicio6
{
	public Class1()
	{
        Func<int, int, int> operacion = (a, b) => a + b;
        Console.WriteLine(operacion(6, 5));
        Console.WriteLine();
        operacion = (a, b) => a * b;
        Console.WriteLine(operacion(6, 5));
        Console.ReadLine();

    }
}
