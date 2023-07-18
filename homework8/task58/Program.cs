// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

int[,] GetRandomMatrix(int row, int column)
{
int[,] matrix = new int[row, column];
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = Random.Shared.Next(1, 10);
    }
}
return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
    }
}

int[,] MultiplicationOfMatrix(int[,] matrix1, int[,] matrix2)  // перемножение 2х матриц
{
    int row = matrix1.GetLength(0);
    int[,] matrix3 = new int[row, row];
    for(int i = 0; i < matrix3.GetLength(0); i++)
    {
        for(int j = 0; j < matrix3.GetLength(0); j++)
        {
            matrix3[i, j] = 0;
            for(int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix3[i, j] = matrix3[i, j] + matrix1[i, k] * matrix2[k, j];
            }
        }
    }   
    return matrix3;
}

const int Rows = 2;
const int Columns = 2;

int[,] myMatrix1 = GetRandomMatrix(Rows, Columns);
Console.WriteLine("Матрица 1:");
PrintMatrix(myMatrix1);
Console.WriteLine();

int[,] myMatrix2 = GetRandomMatrix(Columns, Rows);
Console.WriteLine("Матрица 2:");
PrintMatrix(myMatrix2);
Console.WriteLine();

int[,] myMatrix_1x2 = MultiplicationOfMatrix(myMatrix1, myMatrix2);
Console.WriteLine("Произведение двух матриц: ");
PrintMatrix(myMatrix_1x2);