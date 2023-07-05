// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");           // 23432
string? number = Console.ReadLine();
int IntNumb = Convert.ToInt32(number);

int n1 = IntNumb / 10000;                       // 2
int n2 = IntNumb / 1000 % 10;                   // 23 -> 3
int n3 = IntNumb / 100 % 10;                    // 234 -> 4
int n4 = IntNumb / 10 % 10;                     // 2343 -> 3
int n5 = IntNumb % 10;                          // 2

int Palindrom = (n5 * 10000) + (n4 * 1000) + (n3 * 100) + (n2 * 10) + n1;

if (IntNumb == Palindrom)
{
    Console.WriteLine($"{number} - Да, это число - палиндром!");
}
else if (IntNumb != Palindrom)
{
    Console.WriteLine($"{number} - Нееее, это число - НЕ палиндром!");
}
// else (9999 < IntNumb && IntNumb < 100000);
// {
//     Console.WriteLine($"ОШИБКА: {number} - данное число не является пятизначным");
// }