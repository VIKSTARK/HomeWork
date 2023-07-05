// Задача №22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

//Math.Pow(x, 2) квадрат

Console.WriteLine("введи число и будет магия квадратных чисел");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++ )
{
    Console.WriteLine(Math.Pow(i, 2));
}