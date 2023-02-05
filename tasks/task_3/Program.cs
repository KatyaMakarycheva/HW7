// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] Array = new int[row, column];
FillArray(Array);
Console.WriteLine("Задан массив: ");
PrintMatrix(Array);

void PrintMatrix(int[,] Numbers)              
{
    for (int i = 0; i < Numbers.GetLength(0); i++)
    {
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] Elements)                     
{
    for (int i = 0; i < Elements.GetLength(0); i++)
    {
        for (int j = 0; j < Elements.GetLength(1); j++)
        {
            Elements[i,j] = new Random().Next(5,10);
        }
    }
}

for (int j = 0; j < Array.GetLength(1); j++)
{
    double Diff = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        Diff = (Diff + Array[i, j]);
    }
    Diff = Diff / row;
    
    Console.Write((Math.Round(Diff, 1)) + "; ");
}

