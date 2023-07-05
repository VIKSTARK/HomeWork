// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// Например:
// 456 -> 46
// 782 -> 72
// 918 -> 98

int input = new Random().Next(100, 1000);
    int index = 2;
    int m = 1;
    while (index > 1)
    {
    m *= 10;
    index--;        
    }
    int newNum = (input % m) + (input / (m * 10)) * m;

Console.WriteLine("Случайное число: " + input + ", Результат: " + newNum);