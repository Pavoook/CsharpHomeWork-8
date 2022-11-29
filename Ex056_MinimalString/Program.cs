// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка.

int amountRows = 4;
int amountCols = 4;
int[,] matrix = new int[amountRows, amountCols];
int minBound = 0;
int maxBound = 9;
FillRandomMatrix(matrix, minBound, maxBound);
Console.WriteLine("Задан массив:");
PrintMatrix(matrix);
Console.WriteLine($"{GetIndexOfMinInArray(SumsOfValuesInStrings(matrix)) + 1} строка в сумме наименьшая.");

void FillRandomMatrix(int[,] table, int min, int max)
{
    Random rand = new Random();
    for (int row = 0; row < table.GetLength(0); row++)
    {
        for (int col = 0; col < table.GetLength(1); col++)
        {
            table[row, col] = rand.Next(min, max + 1);
        }
    }
}

void PrintMatrix(int[,] table)
{
    for (int row = 0; row < table.GetLength(0); row++)
    {
        for (int col = 0; col < table.GetLength(1); col++)
        {
            Console.Write($"{table[row, col]}  ");
        }
        Console.WriteLine();
    }
}

int[] SumsOfValuesInStrings(int[,] table)
{
    int[] sums = new int[table.GetLength(0)];
    for (int row = 0; row < table.GetLength(0); row++)
    {
        int sum = 0;
        for (int col = 0; col < table.GetLength(1); col++)
        {
            sum += table[row, col];
        }
        sums[row] = sum;
    }
    return sums;
}

int GetIndexOfMinInArray(int[] array)
{
    int min = array[0];
    int index = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            index = i;
        }
    }
    return index;
}