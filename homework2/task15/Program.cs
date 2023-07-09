// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели, чтобы проверить является ли этот день выходным: ");
string? Days = Console.ReadLine();
int IntDays = Convert.ToInt32(Days);

if (IntDays == 1) Console.WriteLine ("Нет, это не выходной");
if (IntDays == 2) Console.WriteLine ("Нет, это не выходной");
if (IntDays == 3) Console.WriteLine ("Нет, это не выходной");
if (IntDays == 4) Console.WriteLine ("Нет, это не выходной");
if (IntDays == 5) Console.WriteLine ("Нет, это не выходной");
if (IntDays == 6) Console.WriteLine ("Да, это выходной!");
if (IntDays == 7) Console.WriteLine ("Да, это выходной!");
if (IntDays > 7 || IntDays < 1) Console.WriteLine("Нет такого дня, ты не с этой планеты, парень!");