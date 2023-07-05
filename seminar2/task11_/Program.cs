// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// Например:
// 456 -> 46
// 782 -> 72
// 918 -> 98e:\GeekBrains\c


int numb = Random.Shared.Next(100, 1000);
int first = numb / 100;                     // берём сотни
int second = numb % 10;                     // берём единицы
int newNum = first * 10 + second;           // тут сотни в десятки и складываем в единицы

Console.WriteLine("было число = " + numb);
Console.WriteLine("стало число = " + newNum);

Console.WriteLine($"Исходное число {numb}, первая цифра = {first}, вторая цифра = {second}");
Console.WriteLine("Исходное число " + numb + ", первая цифра = " + first + ", вторая цифра = " + second);