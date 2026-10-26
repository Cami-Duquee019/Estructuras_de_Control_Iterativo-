using System;

Console.WriteLine("===Registro de calificaciones===");
byte[]calificaciones = {72, 85, 91, 60, 43, 78, 95, 55, 88, 67};
int suma = 0; 
for(byte lado = 0; lado < 2; lado++)
{
    bool ascendente = (lado==0);
    Console.WriteLine(ascendente ? "Calificaciones en orden ascendente?\n" : 
    "Calificaciones en orden descendente\n");

    int inicio = ascendente ? 0 :  calificaciones.Length - 1;
    int fin = ascendente ? calificaciones.Length  -1: 0;
    int paso = ascendente ? 1 : -1;
    
    for (int iteraciones = inicio; ascendente ? iteraciones <= fin : iteraciones >= fin; iteraciones += paso)
    {
        Console.WriteLine($"Estudiantes {iteraciones + 1}: {calificaciones[iteraciones]}");
    }
}  

    foreach (byte calificacion in calificaciones)
    {
        suma += calificacion;
    }
    Console.WriteLine("=== PROMEDIO DEL GRUPO ===");
    Console.WriteLine($"SUMA DE CALIFICACIONES: {suma}");
    Console.WriteLine($"PROMEDIO DE CALIFICACIONES: {suma / calificaciones.Length}");

    for (int par =0; par < calificaciones.Length; par +=2)
    {
        Console.WriteLine($"=== POSICIONES PARES ===\n" + $"Estudiantes {par}: {calificaciones[par]}");
    }

int intentos = 0;
const string clave = "sena2025";

while(intentos < 3)
{
    Console.WriteLine("Ingrese la contraseña");
    string input = Console.ReadLine() ?? "";
    if(input != clave)
    {
        Console.WriteLine($"\ncontraseña incorecta. TE QUEDAN {2-intentos}");
        intentos += 1;
        if(intentos == 3)
        {
          Console.WriteLine("Acceso bloqueado.");  
        }
    }else
    {
    Console.WriteLine("Aceso permitido.");
    int opcion;
    do
    {
       Console.Write("=== MENÚ PRINCIPAL ===\n1. Ver promedio del grupo\n2. Ver calificación más alta\n3. Salir\nElige una opción:");
       if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = 0;
            }
        switch(opcion)
        {
            case 1: 
            Console.WriteLine("promedio de 78.9");
            break;
            case 2: 
            Console.WriteLine("98.8");
            break;
            case 3: 
            Console.WriteLine("hasta luego");
            break;
            default:
            Console.WriteLine("Opción no válida. Intenta de nuevo.");
            break;
        }
    }while(opcion != 3);
    break;
    }
    
}
Console.WriteLine("\n=== PRIMERA CALIFICACIÓN REPROBATORIA ===");
bool encontrada = false;
for (int i = 0; i < calificaciones.Length; i++)
{
    if (calificaciones[i] < 60)
    {
        Console.WriteLine($"Primera reprobatoria encontrada en la posición {i}: {calificaciones[i]}");
        encontrada = true;
        break; // se detiene la búsqueda
    }
}
if (!encontrada)
{
    Console.WriteLine("No se encontraron calificaciones reprobatorias.");
}

// ============================================================
// 2) foreach + continue: solo aprobatorias (>= 60) y contador
// ============================================================
Console.WriteLine("\n=== CALIFICACIONES APROBATORIAS ===");
int aprobados = 0;
foreach (byte calificacion in calificaciones)
{
    if (calificacion < 60)
    {
        continue; // salta las reprobatorias
    }
    Console.WriteLine($"Aprobó con: {calificacion}");
    aprobados++;
}
Console.WriteLine($"Total de estudiantes que aprobaron: {aprobados}");

// ============================================================
// 3) for con break y continue
// ============================================================
Console.WriteLine("\n=== PROCESAMIENTO CON BREAK Y CONTINUE ===");
for (int i = 0; i < calificaciones.Length; i++)
{
    if (calificaciones[i] < 70)
    {
        continue; // salta las menores a 70
    }
    if (calificaciones[i] >= 95)
    {
        break; // detiene el recorrido al encontrar 95 o más
    }
    Console.WriteLine($"Calificación procesada: {calificaciones[i]}");
}