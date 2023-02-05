// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

double[,] GetArray = new double[3, 4];

void PrintArray(double[,] Numbers)              
{
    for (int i = 0; i < Numbers.GetLength(0); i++)
    {
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            Console.Write($"{GetArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] Col)                      
{
    for (int i = 0; i < Col.GetLength(0); i++)
    {
        for (int j = 0; j < Col.GetLength(1); j++)
        {
            Col[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10 ;             
        }
    }
}

FillArray(GetArray);
PrintArray(GetArray);