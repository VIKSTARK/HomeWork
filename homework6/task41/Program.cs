/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int GetNumbers(ref int M)
{
    int cnt = 0;
    M = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < M; ++i)
    {
        int new_a = Convert.ToInt32(Console.ReadLine());
        if (new_a > 0)
            cnt++;
    }
    return cnt;
}
int R = 0;
int Q = GetNumbers(ref R);
Console.WriteLine($"for {R} variables {Q}");