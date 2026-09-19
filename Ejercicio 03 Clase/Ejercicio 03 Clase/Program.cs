Console.WriteLine("EJERCICIO_3");                                    //#1
Console.WriteLine("CÁLCULO DEL PROMEDIO DE TRES CALIFICACIONES");    //Promedio de 3 calificaciones
Console.WriteLine();                                                 //Instruccion para dejar un espacio en blanco en la consola

Console.Write("Ingrese la primera calificación: ");
double calificacion1 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 1

Console.Write("Ingrese la segunda calificación: ");
double calificacion2 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 2

Console.Write("Ingrese la tercera calificación: ");
double calificacion3 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 3 

double promedio = (calificacion1 + calificacion2 + calificacion3) / 3.0; //Hacemos la suma y división del promedio

Console.WriteLine();
Console.WriteLine($"El promedio de las tres calificaciones es: {promedio:F2}"); //mandamos a imprimir el promedio
if (promedio == 70)
{

    Console.WriteLine("Alumno Aprobado felicidades!");
}
else if (promedio <= 50)
{
    Console.WriteLine("Alumno deficiente");
}
else if (promedio < 70 && promedio > 51)
{
    Console.WriteLine("Alumno requiere apoyo");
}
else if (promedio < 80 && promedio > 71)
{
    Console.WriteLine("Alumno regular");
}
else if (promedio < 90 && promedio > 81)
{
    Console.WriteLine("Alumno bueno");
}
else if (promedio >= 90)
{
    Console.WriteLine("Alumno excelente");
}