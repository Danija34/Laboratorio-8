Console.Write("Ingrese productos: ");
int productos = int.Parse(Console.ReadLine());
Console.Write("Ingrese Precios de productos: ");
int precios = int.Parse(Console.ReadLine());
int[,] inventario = new int[productos, precios];
for(int i=0; i <productos; i++)
{
    for (int j = 0; j < precios;j++)
    {
        Console.Write($"Ingrese datos del inventario: productos {i + 1}, precios {j + 1} ");
        inventario[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.Write("Ingrese el número a buscar: ");
int buscar = int.Parse(Console.ReadLine());
bool encontrado = false;
for (int i = 0; i < productos; i++)
{
    for (int j = 0; j < precios; j++)
    {
        if (inventario[i, j] == buscar)
        {
            Console.WriteLine($"Encontrado en fila {i + 1}, columna {j + 1}");
            encontrado = true;
        }
    }
}
if (!encontrado)
{
    Console.WriteLine("El valor no se encuentra en el inventario.");
}
