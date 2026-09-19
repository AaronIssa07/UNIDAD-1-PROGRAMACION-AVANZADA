using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJERCICIO 1: CÁLCULO DE POTENCIA ELÉCTRICA DE UN MOTOR CD"); //Planteamiento del problema      
            Console.Write("Ingrese el voltaje: ");  // Recopilacion de datos: Solicitar al usuario el voltaje y la corriente
            double v = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la corriente: ");
            double i = Convert.ToDouble(Console.ReadLine());

                                                          
            double p = v * i;                       // Operación: Calcular la potencia eléctrica utilizando la fórmula P = V * I

            Console.WriteLine($"\nPotencia calculada: {p} W");

                                                                       
            if (p <= 120) // Comparacion y clasificacion de la potencia al usuario
            {
                Console.WriteLine("Estado: CONSUMO NORMAL"); // Clasificación de la potencia calculada
            }
            else
            {
                Console.WriteLine("Estado: ADVERTENCIA: CONSUMO ELEVADO"); // Clasificación de la potencia calculada
            }
        }
    }
}