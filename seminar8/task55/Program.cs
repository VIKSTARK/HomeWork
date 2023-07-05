//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

int[,] MatrizenTransponieren(int[,] matrix)
{
    int rowCount = matrix.GetLength(0);
    int columnCount = matrix.GetLength(1);
    int[,] MatrixT = new int[columnCount, rowCount];
    for (int i = 0; i < rowCount; ++i)
        for (int j = 0; j < columnCount; ++j)
        {
            MatrixT[j, i] = matrix[i, j];
        }
    return MatrixT;
}
Console.WriteLine("Task #50");
int[,] MyMatrixNew = GetRandomArray(rows, columns);
PrintMatrixInts(MyMatrix);
Console.WriteLine();
int[,] MatrixT = MatrizenTransponieren(MyMatrix);
PrintMatrixInts(MatrixT);