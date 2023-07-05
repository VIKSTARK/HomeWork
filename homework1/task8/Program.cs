// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N: ");
string? a = Console.ReadLine();
int N = Convert.ToInt32(a);

Console.WriteLine($"Все чётные числа от 1 до {N}: ");
for (int evenNumber=2; evenNumber<=N; evenNumber+=2)
    {
        Console.WriteLine(evenNumber);
    }