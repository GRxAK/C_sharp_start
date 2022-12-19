/*
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/
Console.Clear();
int a = 7;
int b = 49;
Console.WriteLine(a);
Console.WriteLine(b);

if (((a * a) == b) || ((b * b) == a)) {
    Console.WriteLine("Да");
} else {
    Console.WriteLine("Нет");
}
