// Задача 28: Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int ReadInt()   // название функции ReadInt - если этого не будет - Имя "ReadInt" не существует в текущем контексте.
{
    Console.WriteLine("Введите целое число: ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int factorial (int number)
{
    int result = 1;                     // переменная "result" сюда записываются результаты перемножения - начинаем с 1 (т.к. если 0, то получим 0)
    for (int i = 1; i <= number; i++)   // цикл (i = 1 начинаем с умножения на 1, и до тех пор пока счетчик (+1) не дойдет до нашего введенного числа)
    {
        result*= i;                     // перемножение "result" на i
    }
    return result;
}

int number = ReadInt();                 // название функции ReadInt
int factorial1 = factorial(number);
  
Console.WriteLine($"Произведение чисел от 1 до {number} получится {factorial1}");