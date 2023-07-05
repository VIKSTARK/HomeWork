// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//Math.Pow(x, 3) возведение в куб

Console.WriteLine("введи число и будет магия кубических чисел");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++ )
{
    Console.WriteLine(Math.Pow(i, 3));
}