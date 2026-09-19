using System;
namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJERCICIO 5: ANÁLISIS DE VIBRACIÓN EN MOTORES"); //Planteamiento del problema
            Console.WriteLine("Procesa múltiples motores y calcula requerimientos de mantenimiento.\n"); 
            int totalMotores = 0;                     //Variable para contar el total de motores analizados  
            int motoresNormales = 0;                //Variables para contar el total de motores y los que funcionan normalmente
            int motoresMantenimiento = 0;    //Variables para contar el total de motores y los que requieren mantenimiento
            bool continuar = true;           //Variable para controlar el bucle de análisis de motores
            while (continuar)
            {
                totalMotores++;
                Console.Write($"\nIngrese el nombre o ID del motor #{totalMotores}: ");//Solicita al usuario el nombre o ID del motor
                string nombreMotor = Console.ReadLine();
                double sumaVibracion = 0;
                for (int i = 1; i <= 4; i++)
                {
                    Console.Write($"  Medición de vibración {i} (mm/s): ");//Solicita al usuario las mediciones de vibración del motor
                    double vib = Convert.ToDouble(Console.ReadLine());
                    sumaVibracion += vib;
                }
                double promedio = sumaVibracion / 4.0;
                Console.WriteLine($"Promedio de vibración de {nombreMotor}: {promedio:F2} mm/s");//Calcula el promedio de vibración y lo muestra al usuario
                if (promedio <= 4.5)
                {
                    Console.WriteLine("Estado: FUNCIONAMIENTO NORMAL DEL MOTOR"); //Si el promedio es menor o igual a 4.5 mm/s, se considera que el motor funciona normalmente

                    motoresNormales++;
                }
                else
                {
                    Console.WriteLine("Estado: EL MOTOR REQUIERE MANTENIMIENTO"); //Si el promedio es mayor a 4.5 mm/s, se considera que el motor requiere mantenimiento
                    motoresMantenimiento++;
                }
                Console.Write("\n¿Desea analizar otro motor? (S/N): "); //Pregunta al usuario si desea analizar otro motor
                string respuesta = Console.ReadLine().Trim().ToUpper();
                if (respuesta != "S")//Si la respuesta es diferente a "S", se termina el bucle
                {
                    continuar = false;
                }
            }
            Console.WriteLine("\n================ RESUMEN GLOBAL ================"); //Muestra un resumen global de los motores analizados
            Console.WriteLine($"Total de motores evaluados: {totalMotores}");
            Console.WriteLine($"Cantidad de motores con funcionamiento normal: {motoresNormales}");
            Console.WriteLine($"Cantidad de motores que requieren mantenimiento: {motoresMantenimiento}");
        }
    }
}