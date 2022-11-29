// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int minBound = 0;
int maxBound = 9;

int amountRows1 = 2;
int amountCols1 = 2;
int[,] matrix1 = new int[amountRows1, amountCols1];
FillRandomMatrix(matrix1, minBound, maxBound);
Console.WriteLine("Дана матрица 1:");
PrintMatrix(matrix1);

int amountRows2 = 2;
int amountCols2 = 2;
int[,] matrix2 = new int[amountRows2, amountCols2];
FillRandomMatrix(matrix2, minBound, maxBound);
Console.WriteLine("Дана матрица 2:");
PrintMatrix(matrix2);

int[,] mutiplyMatrix = GetMatrixMultiplication(matrix1, matrix2);
Console.WriteLine("Произведение этих матриц:");
PrintMatrix(mutiplyMatrix);


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

int[,] GetMatrixMultiplication(int[,] table1, int[,] table2)
{
    int[,] resultMatrix = new int[table1.GetLength(0), table2.GetLength(1)];
    for (int row = 0; row < table1.GetLength(0); row++)
    {
        for (int col = 0; col < table2.GetLength(1); col++)
        {
            int sum = 0;
            for (int index = 0; index < table1.GetLength(1); index++)
            {
                sum += table1[row, index] * table2[index, col];
            }
            resultMatrix[row, col] = sum;
        }
    }
    return resultMatrix;
}