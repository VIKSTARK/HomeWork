// Напишите программу, которая на вход принимает два числа и проверяет, является ли одно число квадратом другого.

// a = 5, b = 25 -> да 
// a = -4, b = 16 -> да
// a = 25, b = 5 -> да 
// a = 8, b = 9 -> нет

Console.WriteLine("Введите первое число");
string? a = Console.ReadLine();
int numberA = Convert.ToInt32(a);
Console.WriteLine("Введите второе число");
string? b = Console.ReadLine();
int numberB = Convert.ToInt32(b);

if (numberA * numberA == numberB || numberB * numberB == numberA)
{
	Console.WriteLine("ОДНО ИЗ ЧИСЕЛ ЯВЛЯЕТСЯ КВАДРАТОМ ДРУГОГО");
}
else
{
	Console.WriteLine("ОДНО ИЗ ЧИСЕЛ НЕ ЯВЛЯЕТСЯ КВАДРАТОМ ДРУГОГО");
}