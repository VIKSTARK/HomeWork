// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число от 1 до 100000: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (99 < number && number < 1000)            // если число 3-значное
{
    int x1 = number % 10;
    Console.WriteLine($"{x1} - третья цифра числа");
}

else if (999 < number && number < 10000)          // если число 4-значное
{
    int x1 = number % 10;
    int x2 = (number % 100 - x1) / 10;
    Console.WriteLine($"{x2} - третья цифра числа");
}

else if (9999 < number && number < 100000)        // если число 5-значное
{
    int x1 = number % 10;
    int x2 = (number % 100 - x1) / 10;
    int x3 = (number % 1000 - x2) / 100;
    Console.WriteLine($"{x3} - третья цифра числа");
}

else if (number > 100000)                         // если число 6-значное и выше
{
    Console.Write("Слишком длинное число для данной программы. Попробуйте снова.");
}