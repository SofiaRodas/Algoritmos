// Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor de los números ingresados.

do
{
    Console.WriteLine("INGRESE TRES NUMEROS DIFERENTES:");
    Console.Write("Ingrese primer numero:");
    var Numero1 = Console.ReadLine();
    Console.Write("Ingrese segundo numero:");
    var Numero2 = Console.ReadLine();
    Console.Write("Ingrese tercer numero:");
    var Numero3 = Console.ReadLine();

    if (int.TryParse(Numero1, out int intNumero1) && int.TryParse(Numero2, out int intNumero2) && int.TryParse(Numero3, out int intNumero3))
    {

        if (intNumero1 != intNumero2 && intNumero3 != intNumero2 && intNumero3 != intNumero1)
        {
            if (intNumero1 > intNumero2 && intNumero1 > intNumero3)
            {
                Console.WriteLine($"El numero {intNumero1} es el mayor");
            }
            else if (intNumero2 > intNumero1 && intNumero2 > intNumero3)
            {
                Console.WriteLine($"El numero {intNumero2} es el mayor");
            }
            else
            {
                Console.WriteLine($"El numero {intNumero3} es el mayor");
            }
        }
        else
        {
            if (intNumero1 != intNumero2 && intNumero3 != intNumero2 && intNumero3 != intNumero1)
            {
                if (intNumero1 > intNumero2 && intNumero1 > intNumero3)
                {
                    Console.WriteLine($"El numero {intNumero1} es el mayor");
                }
                else if (intNumero2 > intNumero1 && intNumero2 > intNumero3)
                {
                    Console.WriteLine($"El numero {intNumero2} es el mayor");
                }
                else
                {
                    Console.WriteLine($"El numero {intNumero3} es el mayor");
                }
            }
            else
            {
                Console.WriteLine("Debe Ingresar 3 Numeros diferente:");
            }

        }

    }
    else
    {
        Console.WriteLine("Debe Ingresar solo numeros");

    }
} while (true);
