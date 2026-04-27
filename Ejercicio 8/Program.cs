Console.Write("Ingrese el número de jugadores: ");
int jugadores = int.Parse(Console.ReadLine());
Console.Write("Ingrese el número de niveles: ");
int niveles = int.Parse(Console.ReadLine());
int[,] puntajes = new int[jugadores, niveles];
for (int i = 0; i < jugadores; i++)
{
    for (int j = 0; j < niveles; j++)
    {
        Console.Write($"Jugador {i + 1}, Nivel {j + 1}: ");
        puntajes[i, j] = int.Parse(Console.ReadLine());
    }
}
int mayor = puntajes[0, 0];
for (int i = 0; i < jugadores; i++)
{
    for (int j = 0; j < niveles; j++)
    {
        if (puntajes[i, j] > mayor)
        {
            mayor = puntajes[i, j];
        }
    }
}
Console.WriteLine("El puntaje más alto del juego es: " + mayor);
