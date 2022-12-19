/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/
Console.Clear();
int numb = new Random().Next(100, 1000);

Console.WriteLine(numb);

Console.Write((numb / 100) );
Console.WriteLine((numb % 10));