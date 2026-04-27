Console.Write("Ingrese el numero de productos");
int productos = int.Parse(Console.ReadLine());
Console.Write("Ingrese la cantidad de días: ");
int dias = int.Parse(Console.ReadLine());
int[,] ventas = new int[productos, dias];
for (int i = 0; i < productos; i++)
{
    for (int j = 0; j < dias; j++)
    {
        Console.Write($"Ingrese ventas del producto {i + 1}, día {j + 1}: ");
        ventas[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.Write("Ingrese el número del producto que desea consultar: ");
int productobuscar= int.Parse(Console.ReadLine());
if (productobuscar < 1 || productobuscar > productos)
{
    Console.WriteLine("Producto inválido.");
    return;
}
Console.WriteLine($"Ventas del producto {productobuscar}:");
for (int j = 0; j < dias; j++)
{
    Console.WriteLine($"Día {j + 1}: {ventas[productobuscar- 1, j]}");
}

