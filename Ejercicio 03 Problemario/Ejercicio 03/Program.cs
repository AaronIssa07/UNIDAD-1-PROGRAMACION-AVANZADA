using System;

namespace Ejercicio3
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJERCICIO 3: SIMULACIÓN DE CARGA DE BATERÍA"); // Planteamiento del problema
            Console.WriteLine("Simula el proceso de carga iterativo de una batería de 12.6 V.\n");

            Console.Write("Ingrese el voltaje inicial: "); // Solicita al usuario el voltaje inicial de la batería
            double voltaje = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el incremento de voltaje por ciclo: "); // Solicita al usuario el incremento de voltaje por ciclo

            double incremento = Convert.ToDouble(Console.ReadLine());  

            if (incremento <= 0) // Validación del incremento de voltaje
            {
                Console.WriteLine("ERROR: El incremento debe ser un valor mayor que cero. Simulación cancelada."); //Mensaje de error si el incremento es menor o igual a cero 
            }

            else
            {
                int ciclo = 0; // Inicializa el contador de ciclos
                Console.WriteLine("\nInicio del Proceso de Carga"); // Mensaje de inicio del proceso de carga
                while (voltaje < 12.6)
                {
                    ciclo++; // Incrementa el contador de ciclos
                    voltaje += incremento; // Incrementa el voltaje de la batería

                    Console.WriteLine($"Ciclo {ciclo}: Voltaje actual = {Math.Min(voltaje, 12.6):F2} V"); // Muestra el voltaje actual de la batería
                }
                Console.WriteLine("Simulación finalizada: Batería cargada a 12.6 V o más."); // Mensaje de finalización de la simulaciónZ
            }
        } 
    }
}