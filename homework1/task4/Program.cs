// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
string? a = Console.ReadLine();
int number1 = Convert.ToInt32(a);

Console.WriteLine("Введите второе число: ");
string? b = Console.ReadLine();
int number2 = Convert.ToInt32(b);

Console.WriteLine("Введите третье число: ");
string? c = Console.ReadLine();
int number3 = Convert.ToInt32(c);

int max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;
Console.WriteLine("Максимальное из введённых чисел: " + max);