﻿/**Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10**/

int[] arr = new int[32];
void bintype(int a)
{
    for (int i = 0; i < 32; i++)
    {
        arr[i] = (int)(a>>i &0x01);
    }
}