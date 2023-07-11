/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

﻿Console.WriteLine("Введите количество чисел:");
int num = Convert.ToInt32(Console.ReadLine());
int m = 0;
int count = 0;
for(int i = 1; i <= num; i++)
{
    Console.WriteLine(i + " число:");
    m = Convert.ToInt32(Console.ReadLine());
    if(m > 0) count++;
}
Console.WriteLine("Количество чисел больше 0: " + count);