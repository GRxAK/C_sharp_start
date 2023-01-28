Console.Clear();
/* Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] CreateIntArray2D (int y, int x)
{
    int[,] arr = new int[y,x];
    for (int i=0; i < arr.GetLength(0); i++)
    {
        for (int j=0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(10);
        }
    }
    return arr;
}

void PrintIntArray2D(int[,] arr)
{
    for (int i=0; i < arr.GetLength(0); i++)
    {
        for (int j=0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] SortDescendingRowIntArray2D(int[,] arr)
{
    for (int i=0; i < arr.GetLength(0); i++)
    {
        for (int count = 1; count < arr.GetLength(1); count++)
        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                if (arr[i, j] < arr[i, j + 1])
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, j + 1];
                    arr[i, j + 1] = temp;
                }
            }
        }
    }
    return arr;
}

void LessonOne()
{
    Console.WriteLine("Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
    Console.WriteLine();
    int[,] arrOne = CreateIntArray2D(4,4);
    PrintIntArray2D(arrOne);
    SortDescendingRowIntArray2D(arrOne);
    Console.WriteLine();
    PrintIntArray2D(arrOne);
    Console.WriteLine();
}


/* Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int MinSumRowIntArray2D(int[,] arr)
{
    int[] sum = new int[arr.GetLength(0)];
    for (int i=0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum[i] += arr[i,j];
        }
    }
    int minRow = 0;
    for (int m=1; m < sum.Length; m++)
    {
        if (sum[minRow] > sum[m]) minRow = m;
    }
    return ++minRow;
}

void LessonTwo()
{
    Console.WriteLine("Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
    Console.WriteLine();
    int[,] arrTwo = CreateIntArray2D(4,3);
    PrintIntArray2D(arrTwo);
    Console.WriteLine();
    int numbRow = MinSumRowIntArray2D(arrTwo);
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {numbRow} строка");
    Console.WriteLine();
}


/* Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] MultiMatrixInt (int[,] A, int[,] B)
{
    int rowsA = A.GetLength(0);
    int colsA = A.GetLength(1);
    int rowsB = B.GetLength(0);
    int colsB = B.GetLength(1);
    int[,] C = new int[rowsA, colsB];
    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < colsB; j++)
        {
            for (int k = 0; k < colsA; k++)
            {
                C[i, j] += A[i, k] * B[k, j];
            }
        }
    }
    return C;
} 

void LessonThree()
{
    Console.WriteLine("Напишите программу, которая будет находить произведение двух матриц.");
    Console.WriteLine();
    int[,] matrixOne = CreateIntArray2D(2,2);
    int[,] matrixTwo = CreateIntArray2D(2,2);
    PrintIntArray2D(matrixOne);
    Console.WriteLine();
    PrintIntArray2D(matrixTwo);
    Console.WriteLine();
    if (matrixOne.GetLength(1) != matrixTwo.GetLength(0))
    {
        Console.WriteLine("С такими размерами и порядком умножения нельзя найти их произведение");
    }
    else {
        int[,] matrixThree = MultiMatrixInt(matrixOne, matrixTwo);
        Console.WriteLine("Результат произведение двух матриц:");
        PrintIntArray2D(matrixThree);
    }
    Console.WriteLine();
}

/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[] CrateNorepeatNumbersArray (int leng)
{
    Random random = new Random();
    int[] numbs = new int[leng];
    for (int l=0; l < numbs.Length; l++)
    {
        bool contains;
        int next;
        do
        {
            next = random.Next(10,100);
            contains = false;
            for (int index=0; index < l; index++)
            {
                int c = numbs[index];
                if (c == next)
                {
                    contains = true;
                    break;
                }
            }
        } 
        while (contains);
        numbs[l] = next;
    }
    return numbs;
}

int[,,] CreateIntArray3D(int z, int y, int x)
{
    int[,,] arr = new int[z, y, x];
    int[] numbs = CrateNorepeatNumbersArray(arr.Length);
    int n = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {   
                arr[i,j,k] = numbs[n++];
            }
        }
    }
    return arr;
}

void PrintIntArray3D(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i,j,k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void LessonFour()
{
    Console.WriteLine("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,");
    Console.WriteLine("которая будет построчно выводить массив, добавляя индексы каждого элемента.");
    Console.WriteLine();
    int[,,] arrFour = CreateIntArray3D(2,2,2);
    PrintIntArray3D(arrFour);
    Console.WriteLine();
}

/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

string[,] CreateSpiralArray(int y, int x)
{
    string[,] arr = new string[y, x];
    int value = 1;
    string numb = string.Empty;
    int minRow = 0;
    int maxRow = arr.GetLength(0) - 1;
    int minCol = 0;
    int maxCol = arr.GetLength(1) - 1;

    string DoNumberString(int value)
    {
        if (value < 10) numb = $"0{value}";
        else numb = $"{value}";
        return numb;
    }

    while (value <= arr.Length)
    {
        for (int i = minCol; i <= maxCol; i++)
        {
            arr[minRow, i] = DoNumberString(value);
            value++;
        }

        for (int i = minRow + 1; i <= maxRow; i++)
        {
            arr[i, maxCol] = DoNumberString(value);
            value++;
        }

        for (int i = maxCol - 1; i >= minCol; i--)
        {
            arr[maxRow, i] = DoNumberString(value);
            value++;
        }

        for (int i = maxRow - 1; i >= minRow + 1; i--)
        {
            arr[i, minCol] = DoNumberString(value);
            value++;
        }

        minRow++;
        minCol++;
        maxRow--;
        maxCol--;
    }
    return arr;
}

void PrintStringArray2D(string[,] arr)
{
    for (int i=0; i < arr.GetLength(0); i++)
    {
        for (int j=0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}  ");
        }
        Console.WriteLine();
    }
}

void LessonFive()
{
    Console.WriteLine("Напишите программу, которая заполнит спирально массив 4 на 4.");
    Console.WriteLine();
    string[,] arrFive = CreateSpiralArray(4,4);
    PrintStringArray2D(arrFive);
    Console.WriteLine();
}

// запускаем задачки на выбор
void GoHomework()
{
    Console.WriteLine("Введите норме задачки 1, 2, 3, 4 или 5");
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
        case "4":
            LessonFour();
        break;
        case "5":
            LessonFive();
        break;
    }
}

GoHomework();