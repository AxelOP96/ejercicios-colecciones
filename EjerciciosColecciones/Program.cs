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
    Console.WriteLine("La nota es " + nota);
    suma += nota;
}
Console.WriteLine("El promedio de las notas del alumno es " + (suma / notas.Count));
/*Dada las edades de 20 personas guardadas en una lista, imprimir por pantalla
cuántos son mayores de edad y cuántos no.*/
Console.WriteLine("Ejercicio 2: edades y mayores de edad");
List<int> edades = new List<int>();
edades.Add(59);
edades.Add(13);
edades.Add(30);
edades.Add(20);
edades.Add(1);
edades.Add(3);
edades.Add(8);
edades.Add(10);
edades.Add(33);
edades.Add(19);
edades.Add(8);
edades.Add(14);
edades.Add(20);
edades.Add(35);
edades.Add(59);
edades.Add(15);
edades.Add(22);
edades.Add(45);
edades.Add(25);
edades.Add(50);
int menores = 0;
int mayores = 0;
foreach(int edad in edades)
{
    if (edad >= 18)
        mayores++;
    else
        menores++;
}
Console.WriteLine("Los menores son " + menores + " y la cantidad de mayores es " + mayores);
/*Dado una lista de nombres de estudiantes, imprimir el que tenga más letras, y el que
tenga menos letras de todos.*/
Console.WriteLine("Ejercicio 3: longitud de la lista");
List<string> listaEstudiantes = new List<string>();
listaEstudiantes.Add("Lenny");
listaEstudiantes.Add("Tomy");
listaEstudiantes.Add("Axel");
listaEstudiantes.Add("Michel");
listaEstudiantes.Add("Alejandro");
listaEstudiantes.Add("Uma");
listaEstudiantes.Add("Aaron");
string masLetras = "";
string menosLetras = "aaaaaaaaaaaaaaaaaaaaaaaaa";
foreach(string letras in listaEstudiantes)
{
    if (masLetras.Length <= letras.Length) masLetras = letras;
    if (menosLetras.Length >= letras.Length) menosLetras = letras;
}
Console.WriteLine("El que tiene menos letras es " + menosLetras + " y el que tiene mas letras es " + masLetras);
/*Crear una variable para guardar los nombres de elementos para una “lista de
supermercado”. Solicitar al usuario que ingrese el nombre de un elemento que va a
comprar en el super y verificar que el elemento esté en la lista. Si no está, agregarlo
e indicar que no estaba. Si está, quitarlo de la lista, y avisar que sí estaba. Al
finalizar mostrar por pantalla los elementos que no compró y los que compró, pero
no estaban en la lista. Si se quiere, mostrar también todos los elementos que el
usuario compró. Para salir el usuario debe ingresar “fin”.*/
Console.WriteLine("Ejercicio 4: Lista del supermercado");
/*Crear una matriz de 5 x 5. Almacenar una ‘I’ en lugares impares y una ‘P’ en lugares
pares. Imprimir la matriz por pantalla*/
Console.WriteLine("Ejercicio 5: Matriz bidimensional");
string[,] miMatriz = new string[5, 5];
for(int i=0; i<5; i++)
{
    for(int j=0; j < 5; j++)
    {
        if (j % 2 == 0) miMatriz[i, j] = "I";
        else miMatriz[i, j] = "P";
    }
}
for(int i =0; i < 5; i++)
{
    for(int j=0; j < 5; j++)
    {
        Console.Write(miMatriz[i, j]);
    }
    Console.WriteLine("");
}
/*Se tiene una matriz de 5x7, donde 5 representa la semana de un mes y 7 los días de
la semana. La estructura es para registrar la temperatura diaria de una cabina de
pago, estos oscilan entre los 7 y 38 grados. Deberá llenar la matriz de forma
aleatoria para el mes de mayo donde el primer día inicia en lunes y el último (31) se
ubica en el miércoles (la matriz puede ser inicializada con valores aleatorios desde el
principio del programa, no es necesario pedir los valores al usuario para cada
posición). Se nos pide hacer lo siguiente:
a. Obtener la temperatura más alta y baja de la semana y que día se produjo
(lunes, martes, etc.)
b. Promedio de temperatura de la semana.
c. Temperatura más alta del mes y su día.*/
Console.WriteLine("Ejercicio 6: Matriz mes");
int[,] matrizTemperaturas = new int[5, 7];
Random random = new Random();
for (int i=0; i< 5; i++)
{
    for(int j=0; j < 7; j++)
    {
        matrizTemperaturas[i, j] = random.Next(7,39);
    }
}
int tempAlta = 0;
int tempBaja = 40;
string diaAlta = "";
string diaBaja = "";
int indiceAlta = 0;
int indiceBaja = 0;
int totalSemanal = 0;
int tempAltaMes = 0;
string diaAltaMes = "";
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
    {
        if (tempAlta < matrizTemperaturas[i, j])
        {
            tempAlta = matrizTemperaturas[i, j];
            indiceAlta = j;
        }
        if (tempBaja > matrizTemperaturas[i, j])
        {
            tempBaja = matrizTemperaturas[i, j];
            indiceBaja = j;
        }
        totalSemanal += matrizTemperaturas[i, j];

        if (tempAltaMes < matrizTemperaturas[i, j])
        {
            tempAltaMes = matrizTemperaturas[i, j];
            switch (j)
            {
                case 0: diaAltaMes = "Lunes"; break;
                case 1: diaAltaMes = "Martes"; break;
                case 2: diaAltaMes = "Miércoles"; break;
                case 3: diaAltaMes = "Jueves"; break;
                case 4: diaAltaMes = "Viernes"; break;
                case 5: diaAltaMes = "Sábado"; break;
                case 6: diaAltaMes = "Domingo"; break;
            }
        }
    }
    if (indiceAlta % 7 == 0) diaAlta = "Lunes";
    if (indiceAlta % 7 == 1) diaAlta = "Martes";
    if (indiceAlta % 7 == 2) diaAlta = "Miercoles";
    if (indiceAlta % 7 == 3) diaAlta = "Jueves";
    if (indiceAlta % 7 == 4) diaAlta = "Viernes";
    if (indiceAlta % 7 == 5) diaAlta = "Sábado";
    if (indiceAlta % 7 == 6) diaAlta = "Domingo";
    if (indiceBaja % 7 == 0) diaBaja = "Lunes";
    if (indiceBaja % 7 == 1) diaBaja = "Martes";
    if (indiceBaja % 7 == 2) diaBaja = "Miercoles";
    if (indiceBaja % 7 == 3) diaBaja = "Jueves";
    if (indiceBaja % 7 == 4) diaBaja = "Viernes";
    if (indiceBaja % 7 == 5) diaBaja = "Sábado";
    if (indiceBaja % 7 == 6) diaBaja = "Domingo";
    Console.WriteLine("La temperatura mas alta es " + tempAlta + ", el dia es " + diaAlta + " y la mas baja es " + tempBaja + " y el día es " + diaBaja);
    Console.WriteLine("El promedio de temperatura semanal es de " + (totalSemanal / 7));
    
    tempAlta = 0;
    tempBaja = 40;
    totalSemanal = 0;
}
Console.WriteLine("La temperatura más alta del mes es " + tempAltaMes + " °C, y ocurrió el " + diaAltaMes + ".");
/*Almacenar en una matriz las tablas del 1 al 9, teniendo en cuenta que en la primera
fila y la primera columna se debe guardar los números (de 0 a 9), estando el cero en
la primera posición (fila 0, columna 0). El resto de los lugares debe ser calculado
usando los números que se dispone, por ejemplo, en la fila 1, calcular 1*1, 1*2, 1*3,
etc. usando las posiciones del array o arreglo. Al finalizar el cálculo, mostrar la matriz
por pantalla*/
Console.WriteLine("Ejercicio 7: Tablas");
int[,] matrizTablas = new int[10, 10];
for (int i = 0; i < 10; i++)
{
    matrizTablas[0, i] = i;  // Primera fila (0)
    matrizTablas[i, 0] = i;  // Primera columna (0)
}
for (int i=1; i < 10; i++)
{
    for(int j = 1; j < 10; j++)
    {
        matrizTablas[i, j] = i * j;
    }
}
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.Write(matrizTablas[i, j] + " ");
    }
    Console.WriteLine("");
}
/*Crear una matriz de 10 x 10, y “esconder” varias ‘X’ en lugares aleatorios (la
cantidad que el programador decida, pero no más de la mitad de los lugares
disponibles en la matriz). El usuario deberá ingresar el lugar donde cree que hay una
X, ingresando la fila y la columna por separado. Informar si acertó o no por cada
ingreso. Se debe pedir al usuario ingresar valores por tantas X que se haya
guardado. El usuario tiene 3 intentos para fallar. Al finalizar (Ya sea porque se
terminaron los 3 intentos, o el jugador acertó todas las X) imprimir por pantalla la
matriz con sus correspondientes X, mostrando un * donde no haya nada.*/
Console.WriteLine("Ejercicio 8: Matriz de X");
string[,] matrizX = new string[10, 10];
for(int i=0; i< 10; i++)
{
    for(int j=0; j<10; j++)
    {
        matrizX[i, j] = "* ";
    }
}
int vidas = 3;
for(int x =0; x < 5; x++)
{
    matrizX[random.Next(0, 10), random.Next(0, 10)] = "X";
}
do
{
    Console.WriteLine("Ingrese fila y columna de la posición de X en la matriz");
    int posicionX = int.Parse(Console.ReadLine());
    int posicionY = int.Parse(Console.ReadLine());
    if (matrizX[posicionX, posicionY].Equals("X")) Console.WriteLine("Acertaste");
    else vidas--;
} while (vidas > 0);


/*Diccionario de calificaciones: Crear un diccionario donde la clave sea el nombre del
alumno y el valor sea su nota. El programa debe permitir:
a. Agregar alumnos y sus notas.
b. Mostrar el promedio general del curso.
c. Indicar el alumno con mejor nota y el de peor nota.
d. Hint: usar Dictionary<string, double> y recorrer con foreach*/
Console.WriteLine("Ejercicio 9: Diccionario de calificaciones");
/*Simulador de atención en ventanilla: Usar una cola (Queue) para simular la atención
de clientes en una ventanilla bancaria.
a. Encolar nombres de clientes.
b. Atender (desencolar) uno por uno hasta que no queden.
c. Mostrar en pantalla quién está siendo atendido y cuántos quedan en la fila.
d. Hint: usar Enqueue(), Dequeue() y Count.*/
Console.WriteLine("Ejercicio 10: Simulador");