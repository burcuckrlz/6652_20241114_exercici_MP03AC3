// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {
//   
//         // TAREA 1: CALCULAR EDAD HUMANA DE UN GATO

//         Console.WriteLine("Seleccione la edad de su gato (0 a 20):");
//         int edadGato = GetSelection(0, 20);

//         if (edadGato == 0)
//         {
//             Console.WriteLine("Su gato tiene menos de 1 año, equivalente a 15 años humanos.");
//         }
//         else if (edadGato == 1)
//         {
//             Console.WriteLine("La edad de su gato equivale a 15 años humanos.");
//         }
//         else if (edadGato == 2)
//         {
//             Console.WriteLine("La edad de su gato equivale a 24 años humanos.");
//         }
//         else
//         {
//             int edadHumana = 24 + ((edadGato - 2) * 4);
//             Console.WriteLine("La edad de su gato equivale a " + edadHumana + " años humanos.");
//         }

//        ---------------------------------------------------
//         TAREA 2: CONTROL DE PRESUPUESTO DIARIO

//         Console.WriteLine("Ingrese su presupuesto diario:");
//         double presupuesto = GetDoubleInput();

//         double gastoTotal = 0;
//         while (gastoTotal < presupuesto)
//         {
//             Console.WriteLine("Ha gastado hasta ahora: " + gastoTotal.ToString("C") + ". Ingrese un nuevo gasto:");
//             double gasto = GetDoubleInput();
//             gastoTotal += gasto;

//             if (gastoTotal > presupuesto)
//             {
//                 Console.WriteLine("¡Ha excedido su presupuesto! Gasto total: " + gastoTotal.ToString("C") + ". Sea más cuidadoso.");
//                 break;
//             }
//         }

//         ---------------------------------------------------
//         TAREA 3: CÁLCULO DE CONSUMO DIARIO DE AGUA

//         Console.WriteLine("Seleccione su peso (30kg - 200kg):");
//         double peso = GetSelection(30, 200);

//         Console.WriteLine("Seleccione su actividad física diaria en minutos (0 - 300):");
//         int actividad = GetSelection(0, 300);

//         double aguaBase = peso * 0.033;
//         double aguaExtra = (actividad / 30) * 0.35;
//         double aguaTotal = aguaBase + aguaExtra;

//         Console.WriteLine("\nSu consumo diario de agua debe ser: " + aguaTotal.ToString("F2") + " litros.");
//         if (aguaTotal < 2)
//         {
//             Console.WriteLine("¡Debería beber más agua!");
//         }
//         else if (aguaTotal <= 3)
//         {
//             Console.WriteLine("Su consumo de agua está en un nivel saludable.");
//         }
//         else
//         {
//             Console.WriteLine("Necesita mucho agua debido a su actividad física intensa. ¡Manténgase hidratado!");
//         }

//         ---------------------------------------------------
//         TAREA 4: TABLA DE MULTIPLICAR
//         Console.WriteLine("Tabla de multiplicar (1-10):");
//         for (int i = 1; i <= 10; i++)
//         {
//             for (int j = 1; j <= 10; j++)
//             {
//                 Console.Write(i + " x " + j + " = " + (i * j) + "\t");
//             }
//             Console.WriteLine();
//         }

//         ---------------------------------------------------
//         TAREA 5: OPERACIONES CON UNA LISTA

//         List<int> numeros = new List<int>();
//         for (int i = 1; i <= 20; i++)
//         {
//             numeros.Add(i);
//         }

//         #a) Tercer elemento
//         Console.WriteLine("El tercer elemento es: " + numeros[2]);

//         #b) Primeros 5 elementos
//         Console.WriteLine("Los primeros 5 elementos son:");
//         for (int i = 0; i < 5; i++)
//         {
//             Console.WriteLine(numeros[i]);
//         }

//         #c) Primera mitad de la lista
//         Console.WriteLine("La primera mitad de la lista es:");
//         foreach (var num in numeros.GetRange(0, numeros.Count / 2))
//         {
//             Console.WriteLine(num);
//         }

//         #d) Lista en orden inverso
//         Console.WriteLine("Lista en orden inverso:");
//         numeros.Reverse();
//         foreach (var num in numeros)
//         {
//             Console.WriteLine(num);
//         }

//         ---------------------------------------------------
//         TAREA 6A: ENCONTRAR LETRA OCULTA

//         string letraOculta = "m";
//         string palabra;

//         do
//         {
//             Console.WriteLine("Ingrese una palabra:");
//             palabra = Console.ReadLine();

//             if (palabra.Contains(letraOculta))
//             {
//                 Console.WriteLine("¡Has encontrado la letra oculta!");
//                 break;
//             }
//         } while (true);

//         ---------------------------------------------------
//         TAREA 6B: DESGLOSE DE UNA FRASE

//         Console.WriteLine("Ingrese una frase:");
//         string frase = Console.ReadLine();

//         for (int i = 0; i < frase.Length; i++)
//         {
//             Console.WriteLine((i + 1) + ". carácter: " + frase[i]);
//         }

//         ---------------------------------------------------
//         TAREA 7: TRIÁNGULO DE ASTERISCOS


//         static void Main(string[] args)
//         {
//             Imprimir un triángulo de asteriscos de altura 15
//             int altura = 15;

//             for (int i = 1; i <= altura; i++)
//             {
//                Imprimir i asteriscos en la fila i
//                Console.WriteLine(new string('*', i));
//             }
//         }
//     }
