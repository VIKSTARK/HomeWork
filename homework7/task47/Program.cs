// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

const int mRows = 3;
const int nColumns = 4;
float[,] GetRandomArray(int mrows, int ncolumns)
{
    float[,] matrix = new float[mrows, ncolumns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.NextSingle() * 100;
        }
    }
    return matrix;
}

void PrintMatrix(float[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

float[,] MatrixX = GetRandomArray(mRows, nColumns);
PrintMatrix(MatrixX);
Console.WriteLine();