// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// Например:
// 456 -> 46
// 782 -> 72
// 918 -> 98


int number = Random.Shared.Next(100, 1000);
Console.WriteLine(number);
int firstDigit = number / 100;
Console.WriteLine(firstDigit);
int lastDigit = number % 10;
Console.WriteLine(lastDigit);
int midDigit = firstDigit * 10 + lastDigit;
Console.WriteLine(midDigit);
