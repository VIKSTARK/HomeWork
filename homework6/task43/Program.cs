﻿/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.WriteLine("Введите через пробел значения k1 и b1: ");
decimal x;
decimal y1, y2;
string[] kb = Console.ReadLine().Split(" ");
decimal k1 = Convert.ToDecimal(kb[0]);
decimal b1 = Convert.ToDecimal(kb[1]);
Console.WriteLine("Введите через пробел значения k2 и b2: ");
kb = Console.ReadLine().Split(" ");
decimal k2 = Convert.ToDecimal(kb[0]);
decimal b2 = Convert.ToDecimal(kb[1]);
x = (b2 - b1) / (k1 - k2);
y1 = k1 * x + b1;
y2 = k2 * x + b2;
Console.WriteLine("Координаты точки пересечения двух прямых x = " + x + "  y1 = " + y1 + "  y2 = " + y2);