Console.Clear();
/* Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
*/

int[,] CrateIntArray2D (int y, int x)
{
    int[,] arr = new int[y,x];
    for (int i=0; i < arr.GetLength(0); i++)
    {
        for (int j=0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(10, 100);
        }
    }
    return arr;
}

void PrintIntArray2D (int[,] arr)
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

int[,] ReversFirstLastRowIntArray2D (int[,] arr)
{
    int[] rowFirst = new int[arr.GetLength(0)];
    int lastIndexRow = arr.GetLength(0) - 1;
    for (int j=0; j < arr.GetLength(1); j++)
    {
        rowFirst[j] = arr[0,j];
        arr[0,j] = arr[lastIndexRow, j];
        arr[lastIndexRow, j] = rowFirst[j];
    }
    return arr;
}

void LessonOne()
{
    int[,] arrOne = CrateIntArray2D(4,4);
    PrintIntArray2D(arrOne);
    Console.WriteLine();
    ReversFirstLastRowIntArray2D(arrOne);
    PrintIntArray2D(arrOne);
    Console.WriteLine();
}

// LessonOne();

/* Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/

int[,] ReversRowColArray2D (int[,] arr)
{
    int[,] newArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i=0; i < arr.GetLength(0); i++)
    {
        for (int j=0; j < arr.GetLength(1); j++)
        {
            newArr[j,i] = arr[i,j];
        }
    }
    return newArr;
}

void LessonTwo()
{
    int[,] arrTwo = CrateIntArray2D(4,4);
    PrintIntArray2D(arrTwo);
    Console.WriteLine();
    arrTwo = ReversRowColArray2D(arrTwo);
    PrintIntArray2D(arrTwo);
    Console.WriteLine();
}

// LessonTwo();

/* Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.
*/



/* Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7
*/

/* Вывести первые N строк треугольника Паскаля. 
Сделать вывод в виде равнобедренного треугольника
*/
