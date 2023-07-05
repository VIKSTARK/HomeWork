// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
string? a = Console.ReadLine();
int numberA = Convert.ToInt32(a);

Console.WriteLine("Введите второе число: ");
string? b = Console.ReadLine();
int numberB = Convert.ToInt32(b);

if (numberA == numberB)
{
    Console.WriteLine("Числа равны");
}
if (numberA > numberB)
{
    Console.WriteLine(numberA + " - большее из двух чисел, а " + numberB + " - меньшее.");
}
else
{
    Console.WriteLine(numberB + " - большее из двух чисел, а " + numberA + " - меньшее.");
}