/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

int b1 = Convert.ToInt32(Console.ReadLine());
int k1 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());
System.Drawing.Point pA = new System.Drawing.Point();
System.Drawing.Point pB = new System.Drawing.Point();
pA.X = k1; pA.Y = b1;
pB.X = k2; pB.Y = b2;
System.Drawing.Point pCrossage = new System.Drawing.Point();

pCrossage.X = (pA.X * pB.Y - pB.X * pA.Y) / (pB.X - pA.X);
pCrossage.Y = (pA.Y - pB.Y) / (pB.X - pA.X);

Console.Write($"{pCrossage.X}, {pCrossage.Y}");