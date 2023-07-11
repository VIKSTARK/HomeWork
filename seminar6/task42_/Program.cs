/**Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10**/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int tmp = 0;
string result = "";

while (number != 0)
{
    tmp = number % 2;
    number /= 2;
    result += tmp;
}

for (int i = result.Length - 1; i >= 0; i--)
{
    Console.WriteLine(result[i]);
}