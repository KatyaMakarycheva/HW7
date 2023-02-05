// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] Elements = new int[5, 10];
FillArray(Elements);
Console.WriteLine("Задан массив: ");
PrintMatrix(Elements);
Console.WriteLine("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

void FillArray(int[,] Numbers)                      
{
    for (int i = 0; i < Numbers.GetLength(0); i++)
    {
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            Numbers[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] Col)              
{
    for (int i = 0; i < Col.GetLength(0); i++)
    {
        for (int j = 0; j < Col.GetLength(1); j++)
        {
            Console.Write($"{Elements[i, j]} ");
        }
        Console.WriteLine();
    }
}

if (row > Elements.GetLength(0) || column > Elements.GetLength(1))
{
    Console.WriteLine("Такого числа нет");
}
else
{
    Console.WriteLine($"Элемент равен {Elements[row - 1, column - 1]}");
}