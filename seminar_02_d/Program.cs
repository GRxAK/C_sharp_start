﻿/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

14 -> нет 
46 -> нет 
161 -> да
*/
Console.Clear();
// int a = 161;
int a = 322;

Console.WriteLine(a);
if (((a % 7) == 0) && ((a % 23) == 0)) {
    Console.WriteLine("Делиться на 7 и 23");
} else {
    Console.WriteLine("НЕ делиться на 7 и 23");
}