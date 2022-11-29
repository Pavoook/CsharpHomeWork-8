// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int amountRows = 2;
int amountCols = 2;
int amountLevs = 2;
int[,,] array3D = new int[amountRows, amountCols, amountLevs];
Fill3DArray(array3D);
Print3DArray(array3D);

void Fill3DArray(int[,,] table)
{
    int counter = 0;
    for (int row = 0; row < table.GetLength(0); row++)
    {
        for (int col = 0; col < table.GetLength(1); col++)
        {
            for (int lev = 0; lev < table.GetLength(2); lev++)
            {
                table[row, col, lev] = counter;
                counter++;
            }
        }
    }
}

void Print3DArray(int[,,] table)
{
    for (int row = 0; row < table.GetLength(0); row++)
    {
        for (int col = 0; col < table.GetLength(1); col++)
        {
            for (int lev = 0; lev < table.GetLength(2); lev++)
            {
                Console.Write($"{table[row, col, lev]}({row},{col},{lev})  ");
            }
            Console.WriteLine();
        }
    }
}