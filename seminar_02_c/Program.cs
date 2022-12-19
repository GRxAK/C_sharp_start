/*
Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/
Console.Clear();
// double a = new Random().Next(1, 999);
// double b = new Random().Next(1, 999);
double a = 19;
double b = 5;
double ost = (a % b);

Console.WriteLine(a);
Console.WriteLine(b);

if (ost == 0) {
    Console.WriteLine("Кратное");
} else {
    Console.WriteLine("Не кратное, остаток " + ost);
}