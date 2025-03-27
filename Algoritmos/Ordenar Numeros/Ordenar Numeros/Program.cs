//Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor, el del medio y el menor de los números ingresados.


do 
{
    Console.WriteLine("Ingrese tres numeros Diferentes");
    Console.Write("Ingrese primer numero: ");
    var a = int.Parse(Console.ReadLine());
    Console.Write("Ingrese segundo numero: ");
    var b = int.Parse(Console.ReadLine());
   

    if (a == b)
    {
        Console.Write("Por favor ingrese numeros distintos");
        continue;
    }

    else
    {
        Console.Write("Ingrese tercer numero: ");
        var c = int.Parse(Console.ReadLine());

        if (c != a && b != c)
        {
            if (a > b && b > c)
            {
                Console.WriteLine($"El numero mayor es: {a}, el numero del medio es: {b} y el menor es: {c} ");
            }

            else if (a > b && c < b)
            {
                Console.WriteLine($"El numero mayor es: {a}, el numero del medio es: {c} y el menor es: {b} ");
            }

            else if (b > a && a > c)
            {
                Console.WriteLine($"El numero mayor es: {b}, el numero del medio es: {a} y el menor es: {c} ");
            }

            else if (b > c && a > c)
            {
                Console.WriteLine($"El numero mayor es: {b}, el numero del medio es: {c} y el menor es: {a} ");
            }

            else if (c > a && a > b)
            {
                Console.WriteLine($"El numero mayor es: {c}, el numero del medio es: {a} y el menor es: {b} ");
            }

            else
            {
                Console.WriteLine($"El numero mayor es: {c}, el numero del medio es: {b} y el menor es: {a} ");
            }
        }
        else
        {
            Console.Write("Por favor ingrese numeros distintos");
        } 
    }      
} while (true);


