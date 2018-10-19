using System;

public class Ejercicio4
{
	public Class1()
	{
        int maximo = (from x in secuencia select x).Max();
        Console.WriteLine(maximo);


        Console.ReadLine();

    }
}
