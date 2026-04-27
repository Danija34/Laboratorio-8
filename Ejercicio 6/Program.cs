Console.Write("Ingrese la cantidad de estudiantes: ");
int estudiantes = int.Parse(Console.ReadLine());
Console.Write("Ingrese la cantidad de días: ");
int dias = int.Parse(Console.ReadLine());
int[,] asistencia = new int[estudiantes, dias];
for (int i = 0; i < estudiantes; i++)
{
    for (int j = 0; j < dias; j++)
    {
        Console.Write($"Estudiante {i + 1}, Día {j + 1} (1=Asistió, 0=No): ");
        asistencia[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.Write("Ingrese el número del estudiante a consultar: ");
int estudianteBuscar = int.Parse(Console.ReadLine());
if (estudianteBuscar < 1 || estudianteBuscar > estudiantes)
{
    Console.WriteLine("Estudiante inválido vuelva a intentar. ");
    return;
}
Console.WriteLine($"Registro de asistencia del estudiante {estudianteBuscar}:");

for (int j = 0; j < dias; j++)
{
    Console.WriteLine($"Día {j + 1}: {asistencia[estudianteBuscar - 1, j]}");
}