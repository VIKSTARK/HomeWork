// Задача 26: Напишите программу. которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3         // 78 -> 2          // 89126 -> 5

int ReadInt()                   // название функции ReadInt
{
    Console.WriteLine("Введите целое число: ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int func(int number)
{
    int digits = 1;             // переменная - количество цифр
    while (number >= 10)        // цикл - введенное число больше или равно 10
    {
        number = number / 10;
        digits++;
    }
    return digits;
}

int number = ReadInt();         // название функции ReadInt
int colvo1 = func(number);
  
Console.WriteLine($"Введённое число {number} состоит из {colvo1} цифр");