// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array8 = new int[8];
for (int i = 0; i < array8.Length; i++)
{
    array8[i] = Random.Shared.Next(0,9);
    Console.Write($"{array8[i]} ");
}