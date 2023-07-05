// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// 14212 -> нет 
// 23432 -> да 
// 12821 -> да 
 
Console.Write("Введите пятизначное число: "); 
int N = Convert.ToInt32(Console.ReadLine()); 
 
if (N < 10000 || N > 99999) 
{ 
    Console.WriteLine("Вы ввели не пятизначное число"); 
} 
else if (N >= 10000 && N <= 99999) 
{ 
int num1 = (N / 10000) % 10;  
Console.Write("Первая цифра: "); 
Console.WriteLine(num1); 
int num5 = (N / 1) % 10;  
Console.Write("Пятая цифра: "); 
Console.WriteLine(num5); 
int num2 = (N / 1000) % 10;  
Console.Write("Вторая цифра: "); 
Console.WriteLine(num2); 
int num4 = (N / 10) % 10;  
Console.Write("Четвертая цифра: "); 
Console.WriteLine(num4); 
if(num1 == num5 && num2 == num4) 
{ 
    Console.Write("Это число палиндром"); 
} 
else  
    Console.Write("Это число не палиндром"); 
}