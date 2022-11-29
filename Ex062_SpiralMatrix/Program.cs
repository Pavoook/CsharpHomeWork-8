// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int amountRows = 4;
int amountCols = 4;
int[,] matrix = new int[amountRows, amountCols];
FillSpiralMatrix4x4(matrix);
PrintMatrix(matrix);

void FillSpiralMatrix4x4(int[,] table)
{
    int i = 0;
    int j = 0;
    int counter = 1;
    for (j = 0; j <= 3; j++)     // 1
    {
        table[i, j] = counter;
        counter++;
    }
    for (i = 1; i <= 3; i++)     // 2
    {
        table[i, 3] = counter;
        counter++;
    }
    for (j = 2; j >= 0; j--)     // 3
    {
        table[3, j] = counter;
        counter++;
    }
    for (i = 2; i >= 1; i--)     // 4
    {
        table[i, 0] = counter;
        counter++;
    }
    for (j = 1; j <= 2; j++)     // 5
    {
        table[1, j] = counter;
        counter++;
    }
    
    table[2, 2] = counter;       // 6
    counter++;
    
    table[2, 1] = counter;       // 7
}

void PrintMatrix(int[,] table)
{
    for (int row = 0; row < table.GetLength(0); row++)
    {
        for (int col = 0; col < table.GetLength(1); col++)
        {
            if (table[row, col] < 10) Console.Write($"0{table[row, col]} ");
            else Console.Write($"{table[row, col]} ");
        }
        Console.WriteLine();
    }
}