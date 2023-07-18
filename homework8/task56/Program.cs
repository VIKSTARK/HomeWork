// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int SumOfMatrix(int[,] matrix)
{
    int sum = 0;
    int sumOfRow = 0;
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[0, j];
    }
    for(int i = 1; i < matrix.GetLength(0); i++)
    {
        sumOfRow = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sumOfRow = sumOfRow + matrix[i, j];
        }
        if(sum > sumOfRow) sum = sumOfRow;
    }
    return sum;
}

const int Rows = 3;
const int Columns = 4;
int[,] myMatrix = GetRandomMatrix(Rows, Columns);
PrintMatrix(myMatrix);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов = {SumOfMatrix(myMatrix)} - в строке ");