Console.Write("Ingrese el número de estudiantes: ");
int estudiantes = int.Parse(Console.ReadLine());
Console.Write("Ingrese el número de evaluaciones: ");
int evaluaciones = int.Parse(Console.ReadLine());
double[,] notas = new double[estudiantes, evaluaciones];
for (int i = 0; i < estudiantes; i++)
{
    for (int j = 0; j < evaluaciones; j++)
    {
        Console.Write($"Ingrese la nota del estudiante {i + 1}, evaluación {j + 1}: ");
        notas[i, j] = double.Parse(Console.ReadLine());
    }
}
double mayor = notas[0, 0];

for (int i = 0; i < estudiantes; i++)
{
    for (int j = 0; j < evaluaciones; j++)
    {
        if (notas[i, j] > mayor)
        {
            mayor = notas[i, j];
        }
    }
}
Console.WriteLine("\nLa nota más alta del grupo es: " + mayor);