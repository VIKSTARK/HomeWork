// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

const int rows = 4;
const int columns = 5;

int[,] GetRandomArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = Random.Shared.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

float[] AverageOfColumns(int[,] matrix, int columns)
{
    float[] array = new float[columns];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        array[j] = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            array[j] = array[j] + matrix[i, j];
        }
        array[j] = array[j] / matrix.GetLength(0);
    }
    return array;
}

int[,] myMatrix = GetRandomArray(rows, columns);
float[] average = AverageOfColumns(myMatrix, columns);
PrintMatrix(myMatrix);
Console.WriteLine("__________________________________");
Console.WriteLine(string.Join("\t", average));
Console.WriteLine("Среднее арифмитическое элементов в каждом столбце");