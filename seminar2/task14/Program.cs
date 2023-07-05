// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = numberA % 7;
int numberC = numberA % 23;
if(numberB ==0 && numberC == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}