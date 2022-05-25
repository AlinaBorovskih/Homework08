int m = 4, n = 4;                                                                                                                                   
int[,] mass = new int[n, m];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}
Console.WriteLine();

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < mass.GetLength(0); i++)
{                                                                             
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        for (int k = 0; k < mass.GetLength(1); k++)
        {
            if (mass[i, j] <= mass[i, k]) continue;
            int temp = mass[i, j];
            mass[i, j] = mass[i, k];
            mass[i, k] = temp;
        }
    }
}
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();