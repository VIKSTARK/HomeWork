// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите любое трехзначное число: ");
int numb = Convert.ToInt32(Console.ReadLine());
int digit1 = numb % 10;
int digit2 = (numb % 100 - digit1) / 10;
int digit3 = (numb % 1000 - digit2) / 100;
Console.WriteLine($"Вторая цифра введённого вами трёхзначного числа - {digit2}");