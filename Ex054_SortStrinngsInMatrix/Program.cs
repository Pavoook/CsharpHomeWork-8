// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int amountRows = 4;
int amountCols = 4;
int[,] matrix = new int[amountRows, amountCols];
int minBound = 0;
int maxBound = 9;
FillRandomMatrix(matrix, minBound, maxBound);
Console.WriteLine("Исходная матрица:");
PrintMatrix(matrix);
SortStringsInMatrix(matrix);
Console.WriteLine("Сортированная матрица:");
PrintMatrix(matrix);

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

void SortStringsInMatrix(int[,] table)
{
    int temp = 0;
    for (int row = 0; row < table.GetLength(0); row++)
    {
        for (int col = 0; col + 1 < table.GetLength(1); col++)
        {
            for (int index = 0; index + 1 < table.GetLength(1) - col; index++)
            {
                if (table[row, index] > table[row, index + 1])
                {
                    temp = table[row, index];
                    table[row, index] = table[row, index + 1];
                    table[row, index + 1] = temp;
                }
            }
        }
    } 
}