// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число: ");
string? a = Console.ReadLine();
int number = Convert.ToInt32(a);

if (isEven(number))
{
    Console.WriteLine("Да, число являеся чётным!");
}
else
{
    Console.WriteLine("Нет, введённое число - нечётное!");
}

bool isEven(int a)
{
    return a % 2 == 0;
}