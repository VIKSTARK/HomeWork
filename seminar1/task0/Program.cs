// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.WriteLine("Введите число:"); // "123" != 123
// "123" + "23" = "12323"
// 123 + 23 = 146
// "123" -> 123
string? numberString = Console.ReadLine()!;
int numberInt = Convert.ToInt32(numberString); // "123" -> 123
Console.WriteLine(numberInt * numberInt);

if (numberInt == 100)
{
    Console.WriteLine("ВАШЕ ЧИСЛО РАВНО 100");
}
else
{
    Console.WriteLine("Вам не повезло");
}