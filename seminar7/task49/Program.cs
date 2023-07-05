// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 8 4 5 2
            // Новый массив будет выглядеть 
            // вот так:
            // 1 4 7 2
            // 5 @81@ 2 @9@
            // 8 4 2 4
            // 8 @16@ 5 @4@
const int Rows = 4;
const int Columns = 4;
int[,] GetRandomMatrix(int row, int columns)
{
int[,] matrix = new int[row, columns];   
for(int i = 0; i < matrix.GetLength(0); i++)   //i stroli     j stolbtsy
{
    for(int j = 0; j < matrix.GetLength(0); j++)
    {
        matrix[i, j] = Random.Shared.Next(1, 10);
    }
}
return matrix;
}

int[,] ChangeMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(0); j++)
    {
        if (i % 2 !=0 && j % 2 !=0)
        {
            matrix[i,j] = matrix[i,j] * matrix[i,j];
        }
    }
}
return matrix;
}



void PrintMatrix(int[,] matrix)
{
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(0); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
}

int[,] myMatrix = GetRandomMatrix(Rows, Columns);
PrintMatrix(myMatrix);

Console.WriteLine();

int[,] myMatrix1 = ChangeMatrix(myMatrix);
PrintMatrix(myMatrix);