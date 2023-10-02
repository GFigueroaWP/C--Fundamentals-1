// Create a Loop that prints all values from 1-255
Console.WriteLine("Ejercicio 1: Imprimir todos los valores de 1 a 255");
for (int i = 1; i < 256; i++)
{
    Console.WriteLine(i);
}

// Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
Console.WriteLine("Ejercicio 2: Imprimir todos los valores de 1 a 100 que sean divisibles por 3 o 5, pero no ambos");
for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            continue;
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}

// Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
Console.WriteLine("Ejercicio 3: Modificar el bucle anterior para que imprima 'Fizz' para múltiplos de 3, 'Buzz' para múltiplos de 5 y 'FizzBuzz' para números que son múltiplos de ambos 3 y 5");
for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
}