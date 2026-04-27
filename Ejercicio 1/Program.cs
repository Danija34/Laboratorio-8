
    Console.Write("Ingrese la cantidad de zonas: ");
    int zonas = int.Parse(Console.ReadLine());
    Console.Write("Ingrese la cantidad de días: ");
    int dias = int.Parse(Console.ReadLine());
    double[,] temperaturas = new double[zonas, dias];
    for (int i = 0; i < zonas; i++)
    {
        for (int j = 0; j < dias; j++)
        {
            Console.Write($"Ingrese la temperatura de la zona {i + 1}, día {j + 1}: ");
            temperaturas[i, j] = double.Parse(Console.ReadLine());
        }
    }
    Console.WriteLine("Tabla de temperaturas:");
    Console.Write("Zona y Día\t");
    for (int j = 0; j < dias; j++)
    {
        Console.Write($"Día {j + 1}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < zonas; i++)
    {
        Console.Write($"Zona {i + 1}\t\t");
        for (int j = 0; j < dias; j++)
        {
            Console.Write($"{temperaturas[i, j]} temperatura ");
        }
        Console.WriteLine();
    }
