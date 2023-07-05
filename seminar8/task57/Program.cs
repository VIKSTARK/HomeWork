/*Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. 
Элементы [0, 9]*/

int[] GetFrequencyOfElementsInMatrix(int[,] MyTwoDimensionalArray)
{
    int[] FrequencyArray = new int[10]; // [0,1,2,3,4,5,6,7,8,9]
    int rowCount = MyTwoDimensionalArray.GetLength(0);
    int columnCount = MyTwoDimensionalArray.GetLength(1);
    for (int i = 0; i < rowCount; ++i)
        for (int j = 0; j < columnCount; ++j)
            FrequencyArray[MyTwoDimensionalArray[i, j]]++;
    return FrequencyArray;
}
Console.WriteLine("Task#57");

int[,] GMatrix = GetRandomArray(rows, columns);
PrintMatrixInts(GMatrix);
int[] GFrequency = GetFrequencyOfElementsInMatrix(GMatrix);
for (int i = 0; i < GFrequency.Length; ++i)
{
    Console.Write($"{i} : {GFrequency[i]} | ");
}
Console.WriteLine();

int u = 9;
int a = (u++)+5;
Console.WriteLine(a);
a = (++u)+5;
Console.WriteLine(a);