Console.Clear();
/*
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

// Console.WriteLine("Введите число А:");
// int a = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i <= a; i++)
// {
//     sum = sum + i;
// }
// Console.WriteLine(sum);

int Sum(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum = sum + i;
    }
    return sum;
}
Console.WriteLine("Введите число А:");
int numb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(numb));