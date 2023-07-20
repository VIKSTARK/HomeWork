// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 9
// m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Введите первое натуральное число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число n");
int n = Convert.ToInt32(Console.ReadLine());

int AckermannFunction(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return AckermannFunction(n - 1, 1);
    return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
}

Console.WriteLine(AckermannFunction(n, m));