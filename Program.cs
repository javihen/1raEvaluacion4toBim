using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1raEvaluacion4toBim
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            do
            {
                op = menu();
                switch (op)
                {
                    case 1:
                        Ejercicio1();
                        break;
                    case 2:
                        Ejercicio2();
                        break;
                    case 3:
                        Ejercicio3();
                        break;
                    case 4:
                        Ejercicio4();
                        break;
                }
            } while (op != 5);
        }

        private static void Ejercicio1()
        {
            int n, prom=0, cantP=0, cantI=0;
            int[] vector;
            Console.WriteLine("Ingrese la cantidad de elementos del vector");
            n = int.Parse(Console.ReadLine());
            vector = leerVector(n);
            for(int i = 0; i < n; i++)
            {
                prom = prom + vector[i];
            }
            prom = prom / n;
            for(int j = 0; j < n; j++)
            {
                if (vector[j] < prom)
                    cantP++;
                else
                    cantI++;
            }
            Console.WriteLine("+---------------------------------------------------------...");
            Console.WriteLine("La cantidad de numeros menores al promedio es de " + cantP);
            Console.WriteLine("La cantidad de numeros mayores al promedio es de " + cantI);
            Console.WriteLine("+---------------------------------------------------------...");
            mostrarVector(vector);
        }

        private static void Ejercicio2()
        {
            int[] vector;
            int sum=0, prom, cant=0;
            Console.WriteLine("Ingrese la cantidad de elementos del vector");
            int n = int.Parse(Console.ReadLine());
            vector = new int[n];
            vector = leerVector(n);
            for(int i = 0; i < n; i++)
            {
                if (vector[i] % 2 == 0)
                {
                    
                }
                else
                {
                    sum = sum + vector[i];
                    cant++;
                }
            }
            prom = sum / cant;
            mostrarVector(vector);
            Console.WriteLine("+---------------------------------------------------------...");
            Console.WriteLine("La cantidad del promedio de numeros impares es " + prom);
            Console.WriteLine("+---------------------------------------------------------...");
        }

        private static void Ejercicio3()
        {
            int[] notas;
            String[] nombres, estado;
            Console.WriteLine("Ingrese la cantidad de elementos del vector");
            int n = int.Parse(Console.ReadLine());
            nombres = new string[n];
            notas = new int[n];
            estado = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese el nombre y la nota ["+(i+1)+"]");
                nombres[i] = Console.ReadLine();
                notas[i] = int.Parse(Console.ReadLine());

                if (notas[i] < 61)
                    estado[i] = "REPROBADO";
                else
                    estado[i] = "APROBADO";
            }
                Console.WriteLine("+----------------------------------------------------------+");
                Console.WriteLine("Nro \t Alumno \t\t Nota \t Estado");
                for(int i = 0; i < n; i++)
                {
                    Console.WriteLine("["+(i+1)+".]\t"+nombres[i] + "\t\t" + notas[i] + "\t" + estado[i]);
                }
                Console.WriteLine("+----------------------------------------------------------+");
        }

        private static void Ejercicio4()
        {
            int[] vector;
            int cantP=0, porcentaje;
            Console.WriteLine("Ingrese la cantidad de elementos del vector");
            int n = int.Parse(Console.ReadLine());
            vector = new int[n];
            vector = leerVector(n);
            for (int i = 0; i < n; i++)
            {
                if (vector[i] % 2 == 0)
                {
                    cantP++;
                }
            }
            porcentaje = (cantP * 100) / n;
            mostrarVector(vector);
            Console.WriteLine("+----------------------------------------------------------+");
            Console.WriteLine("El porcentaje de numeros pares es de " + porcentaje + "%");
            Console.WriteLine("+----------------------------------------------------------+");
        }

        private static int menu()
        {
            int op;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" ----- MENU PRINCIPAL -----");
                Console.WriteLine("1. Leer por teclado un vector de n elementos e imprimir cuantos elementos son mayores y cuantos elementos son menores al promedio. ");
                Console.WriteLine("2. Leer un vector de números e imprimir el promedio de los elementos impares.");
                Console.WriteLine("3. Leer un vector de nombres y notas; en un tercer vector guardar el estado del estudiante (APROBADO si su nota es mayor o igual a 61 y REPROBADO en otro caso). Imprimir los tres vectores");
                Console.WriteLine("4. Leer un vector de números e imprimir el porcentaje de pares.");
                Console.WriteLine("5. SALIR.");
                Console.WriteLine("INTRODUCIR UNA OPCION [1-5]");
                Console.ForegroundColor = ConsoleColor.White;
                op = int.Parse(Console.ReadLine());
            } while (op < 1 || op > 5);
            return op;
        }
        static int[] leerVector(int n)
        {
            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("[" + (i + 1) + "]=");
                vector[i] = int.Parse(Console.ReadLine());
            }
            return vector;
        }
        static void mostrarVector(int[] vector)
        {
            Console.WriteLine("+-----ELEMENTOS DEL VECTOR------------>");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + "\t");
            }
            Console.WriteLine("\n+----------------------------------->");
        }
    }
}
