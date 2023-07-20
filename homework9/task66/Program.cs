// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число M");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число N");
int M = Convert.ToInt32(Console.ReadLine());

int sumOfNaturalElements(int N, int M)
{
    if (M == N) return M;
    return N + sumOfNaturalElements(N + 1, M);
}

Console.WriteLine($"Сумма чисел от {N} до {M} равна: {sumOfNaturalElements(N, M)}");