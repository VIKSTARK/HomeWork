// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GetRandomMatrix3(int rowX, int rowY, int rowZ)
{
int[,,] matrix = new int[rowX, rowY, rowZ];
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        for(int k = 0; k < matrix.GetLength(2); k++)
            matrix[i, j, k] = Random.Shared.Next(10, 100);
    }
}
return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

const int RowX = 2;
const int RowY = 3;
const int RowZ = 4;
int[,,] myMatrix = GetRandomMatrix3(RowX, RowY, RowZ);
PrintMatrix(myMatrix);