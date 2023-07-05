/**Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.**/

uint a=5,b=30,c=45;
bool CheckIfTriangleExists(uint a, uint b, uint c)
{
    if (a<0 || b<0||c<0)
    {
        Console.WriteLine("Are you mad?");
    }
    else if (a+b > c && a+c > b && b+c > a)
    {
        Console.WriteLine("Such a triangle exists");
        return true;
    }
    else
    {
        Console.WriteLine("Such a triangle does not exist");
        return false;
    }
}