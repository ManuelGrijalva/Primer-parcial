using System;

Console.Write("Porfavor ingrese un numero entero positivo N mayor que cero: ");
int n = int.Parse(Console.ReadLine());

// Calculamos cuadrados y almacenamos en arreglos
int[] cuadrados = new int[n];
for (int i = 1; i <= n; i++)
{
    cuadrados[i - 1] = i * i;
}

// Imprimimos números primos menores o iguales que el numero ingresado
Console.Write("\nEstos son los números primos menores o iguales del número que ingreso: ");
for (int i = 2; i <= n; i++)
{
    bool esPrimo = true;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            esPrimo = false;
            break;
        }
    }
    if (esPrimo)
    {
        Console.Write(i + " ");
    }
}

// Imprimios los múltiplos de 4 menores o iguales que el nuemro ingresado
Console.Write("\nEstos son los múltiplos de 4, menores o iguales del nuemro que ingreso: ");
for (int i = 4; i <= n; i += 4)
{
    Console.Write(i + " ");
}

// Imprimios la secuencia de números que se incrementan en 3
Console.Write("\nEsta es la secuencia de números que se incrementan en 3: ");
for (int i = 1; i <= n; i += 3)
{
    Console.Write(i + " ");
}

// Imprimimos cuadrados del numero ingresado 
Console.Write("\nEstos son los cuadrados de los números menores o iguales del número que ingreso: ");
for (int i = 0; i < n; i++)
{
    Console.Write(cuadrados[i] + " ");
}

Console.ReadKey();
// Y fin :)