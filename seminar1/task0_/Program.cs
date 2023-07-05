// Напишите программу, которая на вход принимает число и выдаёт его квадрат

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

using System;

Console.WriteLine("Введите число:");
// "123" != 123             - не одно и то же!
// "123" + "23" = "12323"   - сложение 2х СТРОК
// 123 + 23 = 146           - сложение 2х ЧИСЕЛ
// "123" -> 123             - нужно строку конвертировать в число
string? numberString = Console.ReadLine()!; 
int numberInt = Convert.ToInt32(numberString);   // "123" -> 123
Console.WriteLine(numberInt * numberInt);

if (numberInt == 100)
{
    Console.WriteLine("ВАШЕ ЧИСЛО РАВНО 100");
}
else
{
    Console.WriteLine("Вам не повезло");
}