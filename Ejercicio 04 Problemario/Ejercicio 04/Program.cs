using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJERCICIO 4: PRUEBA DE CORRIENTE EN ACTUADOR ELÉCTRICO"); //Planteamiento de problema

            Console.WriteLine("Evalúa lecturas de corriente y genera un diagnóstico de un actuador.\n");//Explicación de la función del programa
            double sumaCorriente = 0;                                //Variable para almacenar la suma de las corrientes ingresadas
            int normales = 0;                                       //Variable para contar las mediciones normales

            int sobrecorrientes = 0;                                //Variable para contar las mediciones de sobrecorriente

            for (int i = 1; i <= 8; i++)                            //Bucle para realizar 8 mediciones
            {
                Console.Write($"Medición {i} - Ingrese corriente (A): ");      //Solicitud de ingreso de corriente

                double corriente = Convert.ToDouble(Console.ReadLine());

                sumaCorriente += corriente;     //Acumulación de la corriente ingresada
                if (corriente <= 5)           //Condición para determinar si la medición es normal o de sobrecorriente
                {
                    Console.WriteLine("--> MEDICIÓN NORMAL");

                    normales++;
                }
                else
                {
                    Console.WriteLine("--> SOBRECORRIENTE DETECTADA");
                    sobrecorrientes++;
                }
            }
            double promedio = sumaCorriente / 8.0;
            Console.WriteLine("\n================ RESUMEN DE PRUEBA ================"); //Tabla de resumen de mediciones

            Console.WriteLine($"Corriente promedio: {promedio:F2} A");
            Console.WriteLine($"Mediciones normales: {normales}");
            Console.WriteLine($"Cantidad de sobrecorrientes: {sobrecorrientes}");

            if (sobrecorrientes == 0)
            {
                Console.WriteLine("Resultado General: ACTUADOR APROBADO"); //Resultado final si no hay sobrecorrientes
            }
            else
            {
                Console.WriteLine("Resultado General: EL ACTUADOR REQUIERE REVISIÓN"); //Resultado final si hay sobrecorrientes
            }
        }
    }
}
