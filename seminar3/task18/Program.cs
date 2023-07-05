// Задача №18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (х и у).

Console.WriteLine("Введите номер четверти с 1 по 4:");
int quater = Convert.ToInt32(Console.ReadLine());

if(quater == 1)
{
    Console.WriteLine("x>0, y>0");
}
else if(quater == 2)
{
    Console.WriteLine("x<0, y>0");
}
else if(quater == 3)
{
    Console.WriteLine("x<0, y<0");
}
else if(quater == 4)
{
    Console.WriteLine("x>0, y<0");
}
else
{
    Console.WriteLine("Не понятно");
}