// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 2

Console.WriteLine("Введите количество строк в массиве");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве");
int y = Convert.ToInt32(Console.ReadLine());

int[,] GetRandomMatrix(int x, int y)
{
    int[,] matrix = new int[x, y];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
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
            Console.Write($"{matrix[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] myMatrix = GetRandomMatrix(x, y);
PrintMatrix(myMatrix);
Console.WriteLine("Введите первую координату");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату");
int y1 = Convert.ToInt32(Console.ReadLine());

if (x1 < x && y1 < y)
{
    Console.WriteLine($"Значение элемента равно {myMatrix[x1, y1]} ");
}
else
{
    Console.WriteLine("Такого числа в массиве нет");
}