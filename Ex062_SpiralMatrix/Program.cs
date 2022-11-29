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
    int row = 0;
    int col = 0;
    int counter = 1;
    // 1
    while (col <= 3)     
    {
        table[row, col] = counter;
        counter++;
        col++;
    }
    col--;
    row++;
    // 2
    while (row <= 3)     
    {
        table[row, col] = counter;
        counter++;
        row++;
    }
    row--;
    col--;
    // 3
    while (col >= 0)     
    {
        table[row, col] = counter;
        counter++;
        col--;
    }
    col++;
    row--;
    // 4
    while (row >= 1)     
    {
        table[row, col] = counter;
        counter++;
        row--;
    }
    row++;
    col++;
    // 5
    while (col <= 2)     
    {
        table[row, col] = counter;
        counter++;
        col++;
    }
    col--;
    row++;
    // 6
    table[row, col] = counter;       
    counter++;
    col--;
    // 7
    table[row, col] = counter;       
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