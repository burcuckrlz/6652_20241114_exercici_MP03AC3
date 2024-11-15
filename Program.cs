// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// === 1. Cálculo de ahorro ===
// Este programa pide al usuario cuánto ahorra mensualmente y calcula el ahorro total en un año usando un bucle for.
/*
using System;

class Programa
{
    static void Main()
    {
        Console.Write("¿Cuánto ahorras mensualmente? ");
        try
        {
            double ahorroMensual = Convert.ToDouble(Console.ReadLine());
            double ahorroAnual = 0;
            for (int mes = 0; mes < 12; mes++)
            {
                ahorroAnual += ahorroMensual;
            }
            Console.WriteLine("El ahorro total en un año es: " + ahorroAnual + " euros.");
        }
        catch
        {
            Console.WriteLine("Por favor, introduce un número válido.");
        }

        Console.WriteLine("Programa terminado.");
    }
}
*/

// === 2. Determina el signo del número ===
// Este programa permite al usuario ingresar números y determina si son positivos, negativos o cero. Finaliza al ingresar 0.
/*
using System;

class Programa
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Introduce un número (0 para salir): ");
            int numero;
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                if (numero > 0)
                {
                    Console.WriteLine("Positivo");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("Negativo");
                }
                else
                {
                    Console.WriteLine("Programa terminado.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }
        }
    }
}
*/

// === 3. Comparación de valores ===
// Este programa pide al usuario ingresar dos números y verifica cuál es mayor, menor o si son iguales.
/*
using System;

class Programa
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Introduce el primer número: ");
            int numero1, numero2;
            if (int.TryParse(Console.ReadLine(), out numero1))
            {
                Console.Write("Introduce el segundo número: ");
                if (int.TryParse(Console.ReadLine(), out numero2))
                {
                    if (numero1 > numero2)
                    {
                        Console.WriteLine("El primer número es mayor.");
                    }
                    else if (numero1 < numero2)
                    {
                        Console.WriteLine("El segundo número es mayor.");
                    }
                    else
                    {
                        Console.WriteLine("Los números son iguales.");
                    }
                    Console.Write("Escribe '1' para salir o cualquier otra tecla para continuar: ");
                    if (Console.ReadLine() == "1")
                    {
                        Console.WriteLine("Programa terminado.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, introduce un número válido.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }
        }
    }
}
*/

// === 4. Inversión con interés ===
// Este programa calcula el saldo acumulado durante 10 años aplicando una tasa de interés anual.
/*
using System;

class Programa
{
    static void Main()
    {
        try
        {
            Console.Write("Introduce la cantidad inicial: ");
            double cantidadInicial = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce la tasa de interés anual (%): ");
            double tasaInteresAnual = Convert.ToDouble(Console.ReadLine()) / 100;

            for (int año = 1; año <= 10; año++)
            {
                cantidadInicial += cantidadInicial * tasaInteresAnual;
                Console.WriteLine("Saldo al final del año " + año + ": " + cantidadInicial.ToString("F2") + " euros.");
            }
        }
        catch
        {
            Console.WriteLine("Por favor, introduce un número válido.");
        }

        Console.WriteLine("Programa terminado.");
    }
}
*/

// === 5. Identificar tipo de triángulo ===
// Este programa determina si un triángulo es equilátero, isósceles o escaleno basándose en las longitudes de sus lados.
/*
using System;

class Programa
{
    static void Main()
    {
        try
        {
            Console.Write("Introduce el primer lado del triángulo: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce el segundo lado del triángulo: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce el tercer lado del triángulo: ");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Triángulo equilátero.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("Triángulo isósceles.");
            }
            else
            {
                Console.WriteLine("Triángulo escaleno.");
            }
        }
        catch
        {
            Console.WriteLine("Por favor, introduce un número válido.");
        }

        Console.WriteLine("Programa terminado.");
    }
}
*/

// === 6. Desglose de dinero en billetes y monedas ===
// Este programa calcula cuántos billetes y monedas se necesitan para una cantidad dada.
/*
using System;

class Programa
{
    static void Main()
    {
        try
        {
            Console.Write("Introduce una cantidad entera: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            int[] billetes = { 100, 50, 20, 10, 5, 1 };

            foreach (int billete in billetes)
            {
                int cantidadBilletes = cantidad / billete;
                cantidad %= billete;
                if (cantidadBilletes > 0)
                {
                    Console.WriteLine(cantidadBilletes + " billetes de " + billete + " euros.");
                }
            }
        }
        catch
        {
            Console.WriteLine("Por favor, introduce una cantidad válida.");
        }

        Console.WriteLine("Programa terminado.");
    }
}
*/
