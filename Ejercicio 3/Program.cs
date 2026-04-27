Console.Write("Ingrese el numero de apartamentos: ");
int apartamentos = int.Parse(Console.ReadLine());
Console.Write("Ingrese el numero de dias: ");
int dias = int.Parse(Console.ReadLine());
int[,] consumo = new int[apartamentos, dias];
int suma = 0;
for(int i=0; i < apartamentos; i++)
{
    for(int j=0; j <dias; j++)
    {
        Console.Write($"Ingrese consumos: {i+1}, dias {j+1} : ");
        consumo[i, j] = int.Parse(Console.ReadLine());
        suma += consumo[i, j];
        Console.WriteLine($"El consumo es de: {suma}");
    }
}