using System;
Console.Clear();

/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

void PrintDoobleArray2D(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            string str = Convert.ToString(arr[i, j]);
            if (str[0] != '-') str = " " + str;
            if (!str.Contains(",")) str += ",0";
            Console.Write(str + "  ");
        }
        Console.WriteLine();
    }
}

double[,] CreateDoobleArray2D(int x, int y)
{
    double[,] arr = new double[x, y];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-9, 10) + Math.Round(new Random().NextDouble(), 1);
            
            // Random random = new Random();  другйо вариант
            // double randomNumber = random.NextDouble() * (max - min) + min;
        }
    }
    return arr;
}

void LessonOne ()
{
    double[,] arrayOne = CreateDoobleArray2D(3, 4);
    PrintDoobleArray2D(arrayOne);
    Console.WriteLine();
}

/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] CreateIntArray2D(int x, int y)
{
    int[,] arr = new int[x, y];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(10);
        }
    }
    return arr;
}

void PrintIntArray2D(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + "  ");
        }
        Console.WriteLine();
    }
}

string SearchNumbDobbleArray2D (int[,] arr, double numb)
{
    string result = string.Empty;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (numb == arr[i,j]) result += $"{arr[i,j]} находитья под индексами [{i}, {j}]  ";
        }
    }
    if (result == string.Empty) result = $"{numb} -> такого числа в массиве нет";
    return result;
}

void LessonTwo ()
{
    int[,] arrayTwo = CreateIntArray2D(4,4);
    PrintIntArray2D(arrayTwo);
    Console.WriteLine();
    double randomNumb = new Random().Next(10);
    Console.WriteLine(SearchNumbDobbleArray2D(arrayTwo, randomNumb));
    Console.WriteLine();
}

/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

double[] AverageByColumnIntArray2D(int[,] arr)
{
    double[] result = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result[j] += arr[i,j];
        }
    }
    for (int c=0; c < result.Length; c++)
    {
        result[c] = Math.Round(result[c] / arr.GetLength(1), 2);
    }
    return result;
}

void LessonThree ()
{
    int[,] arrayThree = CreateIntArray2D(4,4);
    PrintIntArray2D(arrayThree);
    double[] average = AverageByColumnIntArray2D(arrayThree);
    Console.WriteLine();
    Console.WriteLine($"{String.Join("; ", average)}");
}

// запускаем задачки на выбор
void GoHomework()
{
    Console.WriteLine("Введите норме задачки '1', '2' или '3'");
    string lesson = Console.ReadLine();
    Console.WriteLine();
    switch (lesson)
    {
        case "1":
            LessonOne();
        break;
        case "2":
            LessonTwo();
        break;
        case "3":
            LessonThree();
        break;
    }
}

GoHomework();