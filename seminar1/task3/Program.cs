//Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.Write("Введите номер дня недели: ");
string? Days = Console.ReadLine();
int IntDays = Convert.ToInt32(Days);

if (IntDays == 1)
{
    Console.WriteLine("Это понедельник");
}
if (IntDays == 2)
{
    Console.WriteLine("Это вторник");
}
if (IntDays == 3)
{
    Console.WriteLine("Это среда");
}
if (IntDays == 4)
{
    Console.WriteLine("Это четверг");
}        
if (IntDays == 5)
{
    Console.WriteLine("Это пятница");
}
if (IntDays == 6)
{
    Console.WriteLine("Это суббота");
}
if (IntDays == 7)
{
    Console.WriteLine("Это Воскресенье");
}
if (IntDays > 7 || IntDays < 1)
{
    Console.WriteLine("Нет такого дня, ты не с этой планеты, парень!");
}