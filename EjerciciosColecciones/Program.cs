/*Dado que se tiene almacenado en una lista, los resultados de los últimos 10
exámenes de un alumno, calcular su promedio y mostrar por pantalla las 10 notas de
los exámenes y el promedio resultante.*/
Console.WriteLine("Ejercicio 1: notas y promedio con Colecciones");
List<int> notas = new List<int>();
notas.Add(4);
notas.Add(9);
notas.Add(8);
notas.Add(7);
notas.Add(4);
notas.Add(4);
notas.Add(10);
notas.Add(4);
notas.Add(10);
notas.Add(4);
int suma = 0;
foreach(int nota in notas)
{
    suma += nota;
}
Console.WriteLine("El promedio de las notas del alumno es " + (suma / notas.Count));
