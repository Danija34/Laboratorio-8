Console.Write("Ingrese número de filas: ");
int filas = int.Parse(Console.ReadLine());
Console.Write("Ingrese número de columnas: ");
int columnas = int.Parse(Console.ReadLine());
int[,] matriz = new int[filas, columnas];
for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write($"Ingrese valor en [{i + 1},{j + 1}]: ");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.Write("Ingrese el código de error a buscar: ");
int codigo = int.Parse(Console.ReadLine());
bool encontrado = false;
for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        if (matriz[i, j] == codigo)
        {
            Console.WriteLine($"Encontrado en fila {i + 1}, columna {j + 1}");
            encontrado = true;
        }
    }
}
if (!encontrado)
{
    Console.WriteLine("El código no se encuentra en la matriz.");
}
