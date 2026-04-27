Console.Write("Ingrese el número de máquinas: ");
int maquinas = int.Parse(Console.ReadLine());
Console.Write("Ingrese el número de turnos: ");
int turnos = int.Parse(Console.ReadLine());
int[,] produccion = new int[maquinas, turnos];
for (int i = 0; i < maquinas; i++)
{
    for (int j = 0; j < turnos; j++)
    {
        Console.Write($"Máquina {i + 1}, Turno {j + 1}: ");
        produccion[i, j] = int.Parse(Console.ReadLine());
    }
}
int total = 0;

for (int i = 0; i < maquinas; i++)
{
    for (int j = 0; j < turnos; j++)
    {
        total += produccion[i, j];
    }
}
Console.WriteLine("Producción total de la fábrica: " + total);
