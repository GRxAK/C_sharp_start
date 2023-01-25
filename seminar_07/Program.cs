Console.Clear();
/* Задайте двумерный массив размером m×n, 
 заполненный случайными целыми числами
*/

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

/* Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
*/

// int[,] arrayTwo = SumElementArray(5, 5);
// PrintArray(arrayTwo);

// int[,] SumElementArray(int m, int n)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = i + j;
//         }
//     }
//     return result;
// }


/* Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
*/

// int[,] arrayThree = GetArray(5, 5, 0, 10);
// PrintArray(arrayThree);
// Console.WriteLine();

// int[,] SqrEvenElementArray(int[,] arr)
// {
//     for (int x=0; x < arr.GetLength(0); x++)
//     {
//         for (int y=0; y < arr.GetLength(1); y++)
//         {
//             arr[x,y] *= arr[x,y];
//             y++;
//         }
//         x++;
//     }
//     return arr;
// }

// SqrEvenElementArray(arrayThree);
// PrintArray(arrayThree);


/* Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

// int[,] arrayFour = GetArray(4, 4, 0, 10);
// PrintArray(arrayFour);
// Console.WriteLine();

// void SumDiagonalElementsArray(int[,] arr)
// {
//     int sum = 0;
//     for (int x=0; x < arr.GetLength(0); x++)
//     {
//         for (int y=0; y < arr.GetLength(1); y++)
//         {
//             sum += arr[x,y];
//             x++;
//         }
//     }
//     Console.WriteLine(sum);
// }

// SumDiagonalElementsArray(arrayFour);

/* таблица умножения
*/

int[,] MultiplicationTable()
{
    int[,] arr = new int[9, 9];
    for (int x=0; x < arr.GetLength(0); x++)
    {
        for (int y=0; y < arr.GetLength(1); y++)
        {
            arr[x,y] = (x+1) * (y+1);
        }
    }
    return arr;
}

PrintArray(MultiplicationTable());