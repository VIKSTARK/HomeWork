// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// i - строки, j - столбцы

int[,] GetRandomMatrix(int row, int columns)
{
int[,] matrix = new int[row, columns];   
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

void SortedMatrix(int[,] matrix)
{
    int aMax = 0;
    for(int j = 0; j < matrix.GetLength(0); j++)
    {
        for(int i = 0; i < matrix.GetLength(1); i++)
        {
            aMax = matrix[j, i];
            for(int k = i + 1; k < matrix.GetLength(1); k++)
            {
                if(aMax < matrix[j, k])
                {
                    aMax = matrix[j, k];
                    matrix[j, k] = matrix[j, i];
                    matrix[j, i] = aMax;
                }
            }
        }
    }
}

const int Rows = 3;
const int Columns = 4;
int[,] myMatrix = GetRandomMatrix(Rows, Columns);
PrintMatrix(myMatrix);
Console.WriteLine();
SortedMatrix(myMatrix);
PrintMatrix(myMatrix);