using System;

namespace ejerciciosBucles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 13
            // Mostrar numeros pares del 2 al 200


            string menu = @"Menu de ejercicios:
1. Calcular el promedio de un alumno que tiene 7 calificaciones en la materia de Algoritmos
    Avanzados y estructura de Datos.
13. Mostrar los números pares de 2 al 200.
15. Mostrar la sumatoria de los números del 1 al 100.
17. Mostrar un listado con los números del 1 al 100, con su respectivo cuadrado al lado. Cada
    pareja en una línea.
18. Mostrar la tabla de multiplicar de 2 números cualquiera N, que sea leído por la
    computadora.
19. Mostrar un listado con los números consecutivos de M a N, siendo M y N dos valores que
    son leídos por la computadora, tales que M &lt; N.
20. Imprimir un listado que contenga en cada línea: Número par del 2 al 200; múltiplos de 3 del
    3 al 300; múltiplos de 4 del 4 al 400.
21. Resolver la función f (x)= 3x + 2x – 5 para valores de x de 0 a 10, incrementándose de 1 en 1.
22. Resolver la función y = 3x + 15 – 2(2x) + 3, PARA x que toma valores de 1 al 40, de 2 en 2.
23. Resolver la función z= (4/3x – 2X) / (x + 3) para valores de x de –10 hasta N en incrementos
    de 0.5. N es leído por el computador y se debe evitar la división por cero.";
            Console.WriteLine(menu);
            Console.WriteLine("Ingrese el item del ejercicio a revisar:");
            int ejercicio = Convert.ToInt16(Console.ReadLine());
            Int16 i = 0;
            int salir = 0;
            switch (ejercicio)
            {
                case 1:
                    Console.WriteLine("Ingrese notas de alumnos ");
                    double promedio = 0;
                    for(i = 1; i <= 7; i++)
                    {
                        Console.WriteLine($"Ingrese nota del alumno {i}");
                        promedio = promedio + Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine("El promedio de las siete notas es: {0}", promedio/7);
                    Console.WriteLine("¿Desea salir? Si=1/No=2");
                    salir = Convert.ToInt16(Console.ReadLine());
                    if (salir == 2) { goto case 1; }
                    break;
                case 2:
                    Console.WriteLine("Ingrese numeros");
                    //double promedio = 0;
                    for (i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"Ingrese numero {i}");
                        int numero2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{i} \t {numero2 * numero2 * numero2} \t {numero2 * numero2 * numero2 * numero2}");
                    }

                    Console.WriteLine("¿Desea salir? Si=1/No=2");
                    salir = Convert.ToInt16(Console.ReadLine());
                    if (salir == 2) { goto case 2; }
                    break;
                case 3:
                    Console.WriteLine("Ingrese cantidad de numeros a ingresar: ");
                    int nroNumeros = Convert.ToInt32(Console.ReadLine());
                    int[] numeros = new int[nroNumeros];
                    for(i = 0; i < nroNumeros; i++)
                    {
                        Console.WriteLine("Ingrese numero {0}", i + 1);
                        numeros[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    for (i = 0; i < nroNumeros; i++)
                    {
                        if(numeros[i]%2 == 0) { Console.WriteLine("Número par: {0}", numeros[i]); }
                    }
                    Console.WriteLine("¿Desea salir? Si=1/No=2");
                    salir = Convert.ToInt16(Console.ReadLine());
                    if (salir == 2) { goto case 3; }
                    break;
                case 4:
                    //Console.WriteLine("Ingrese cantidad de numeros a ingresar: ");
                    //int nroNumeros4 = Convert.ToInt32(Console.ReadLine());
                    int[] numeros4 = new int[20];
                    int numeroNeutros = 0;
                    int numeroPositivos = 0;
                    int numeroNegativos = 0;
                    for (i = 0; i < 20; i++)
                    {
                        Console.WriteLine("Ingrese numero {0}", i + 1);
                        numeros4[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    for (i = 0; i < 20; i++)
                    {
                        if (numeros4[i] > 0)
                        {
                            numeroPositivos++;
                            Console.WriteLine("Número positivo: {0}", numeros4[i]);
                        }
                        else
                        {
                            if (numeros4[i] == 0)
                            {
                                numeroNeutros++;
                                Console.WriteLine("Número neutro: {0}", numeros4[i]);
                            }
                            else
                            {
                                numeroNegativos++;
                                Console.WriteLine("Número negativo: {0}", numeros4[i]);
                            }
                        }
                    }
                    Console.WriteLine("{0}\t{1}\t{2}", ">0","=0","<0");
                    Console.WriteLine("{0}\t{1}\t{2}", numeroPositivos, numeroNeutros, numeroNegativos);

                    Console.WriteLine("¿Desea salir? Si=1/No=2");
                    salir = Convert.ToInt16(Console.ReadLine());
                    if (salir == 2) { goto case 4; }
                    break;
                case 5:
                    int[] numeros5 = new int[15];
                    for (i = 0; i < 15; i++)
                    {
                        inicio:
                        Console.WriteLine("Ingrese numero {0}", i + 1);
                        numeros5[i] = Convert.ToInt32(Console.ReadLine());
                        if(numeros5[i] > 0) { goto inicio; }
                    }
                    for (i = 0; i < 15; i++)
                    {
                        if (numeros5[i] < 0) { Console.WriteLine("Número: {0}", numeros5[i] * -1); }
                    }

                    Console.WriteLine("¿Desea salir? Si=1/No=2");
                    salir = Convert.ToInt16(Console.ReadLine());
                    if (salir == 2) { goto case 5; }
                    break;
                case 6:
                    int[] numeros6 = new int[10];
                    double notaFinal = 0;
                    int menor = 20;
                    for (i = 0; i < 10; i++)
                    {
                    inicio:
                        Console.WriteLine("Ingrese numero {0}", i + 1);
                        numeros6[i] = Convert.ToInt32(Console.ReadLine());
                        if (numeros6[i] < 0) { goto inicio; }
                        notaFinal = notaFinal + numeros6[i];
                        if (numeros6[i] < menor) { menor = numeros6[i]; }
                    }
                    Console.WriteLine($"El promedio es: {notaFinal / 10}\nLa nota menor es: {menor}");

                    Console.WriteLine("¿Desea salir? Si=1/No=2");
                    salir = Convert.ToInt16(Console.ReadLine());
                    if (salir == 2) { goto case 6; }
                    break;
                case 7:
                    Console.WriteLine("Tabla de multiplicar");
                    Console.WriteLine("Ingrese numero 1:");
                    int num = Convert.ToInt16(Console.ReadLine());
                    i = 0;
                    Console.WriteLine("{0}\t*\t{1}\t=\t{2}", "Numero1", " ", "Numero2");
                    while (i <= 100)
                    {
                        Console.WriteLine("{0}\t*\t{1}\t=\t{2}", num, i, num * i);
                        i++;
                    }

                    Console.WriteLine("¿Desea salir? Si=1/No=2");
                    salir = Convert.ToInt16(Console.ReadLine());
                    if (salir == 2) { goto case 7; }
                    break;
                case 8:
                    Console.WriteLine("RELOJ");
                    int seg, min, hora;

                    break;

                case 13:
                    i = 2;
                    while ((i >= 2) && (i <= 200))
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                        i++;
                    }

                    Console.WriteLine("¿Desea salir? Si=1/No=2");
                    salir = Convert.ToInt16(Console.ReadLine());
                    if (salir == 2) { goto case 13; }
                    break;
                case 15:
                    Console.WriteLine("Sumatoria de los 100 primeros numeros");
                    int sumatoria = 0;
                    i = 1;
                    while (i <= 100)
                    {
                        sumatoria = sumatoria + i;
                        i++;
                    }
                    Console.WriteLine(sumatoria);

                    Console.WriteLine("¿Desea salir? Si=1/No=2");
                    salir = Convert.ToInt16(Console.ReadLine());
                    if (salir == 2) { goto case 15; }
                    break;
                case 17:
                    Console.WriteLine("Indices 1 al 100 con sus cuadrados al lado");
                    i = 1;
                    Console.WriteLine("{0}\t{1}", "Indice", "Cuadrado del indice");
                    while (i <= 100)
                    {
                        Console.WriteLine("{0}\t{1}", i, i * i);
                        i++;
                    }

                    Console.WriteLine("¿Desea salir? Si=1/No=2");
                    salir = Convert.ToInt16(Console.ReadLine());
                    if (salir == 2) { goto case 17; }
                    break;
                case 18:
                    Console.WriteLine("Tabla de multiplicar");
                    Console.WriteLine("Ingrese numero 1:");
                    int num2 = Convert.ToInt16(Console.ReadLine());
                    i = 0;
                    Console.WriteLine("{0}\t*\t{1}\t=\t{2}", "Numero1", " ", "Numero2");
                    while (i <= 100)
                    {
                        Console.WriteLine("{0}\t*\t{1}\t=\t{2}", num2, i, num2 * i);
                        i++;
                    }

                    Console.WriteLine("¿Desea salir? Si=1/No=2");
                    salir = Convert.ToInt16(Console.ReadLine());
                    if (salir == 2) { goto case 18; }
                    break;
                //case 20:
                //    Console.WriteLine("Poner en columnas: pares 2 a 200, multiplos de 3 (3 a 300), multiplos de 4 (4 a 400)");
                //    i = 2;
                //    Console.WriteLine("{0}\t{1}\t{2}", "2-200", "3-300","4-400");
                //    while (i <= 400)
                //    {
                //        int[] pares;
                //        pares[0] = 3;

                //    }
                //    break;
                case 20:
                    Console.WriteLine("Ingrese numero: ");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(factorial(numero));

                    int factorial(int n)
                    {
                        if (n == 1)
                        {
                            return 1;
                        }
                        else
                        {
                            return n * factorial(n - 1);
                        }
                    }
                    break;
            }
        }
    }
}
