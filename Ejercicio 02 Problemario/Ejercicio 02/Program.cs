using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJERCICIO 2: MEDICIÓN DE TEMPERATURA DE UN MOTOR"); //Plantemiento del problema
            Console.WriteLine("Solicita 10 lecturas de temperatura y determina si el promedio es seguro.\n");

            double suma = 0;    // Variable para almacenar la suma de las temperaturas

            for (int i = 1; i <= 10; i++) 
            {
                Console.Write($"Ingrese la medición de temperatura {i} (°C): "); // Solicita la temperatura al usuario
                double temp = Convert.ToDouble(Console.ReadLine());
                suma += temp;
            }

            double promedio = suma / 10.0;                                      //Operacion para calcular el promedio de las temperaturas ingresadas
            Console.WriteLine($"\nTemperatura Promedio: {promedio:F2} °C");    // Muestra el promedio de las temperaturas ingresadas

            if (promedio <= 70)                                                // Condición para determinar si la temperatura promedio es segura
            {
                Console.WriteLine("Estado: TEMPERATURA NORMAL");
            }
            else
            {
                Console.WriteLine("Estado: ALERTA DE TEMPERATURA");
            }
        }
    }
}