
﻿// Construir un programa que pida un número y luego diga si este número es par o no.

do
{
    Console.Write("INGRESA UN NUMERO: ");
    var numeroString = Console.ReadLine();
    var numeroInt = int.Parse(numeroString);

    if (numeroInt % 2 == 0)
    {
        Console.WriteLine("El numero es par");
    }
    else
    {
        Console.WriteLine("El numero es impar");
    }
} while (true);


