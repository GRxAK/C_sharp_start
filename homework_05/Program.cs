Console.Clear();
// Генерация рандомного массива
int[] RandomArray(int leng, int min, int max)
{
    int[] arrey = new int[leng];
    for (int i=0; i < arrey.Length; i++)
    {
        arrey[i] = new Random().Next(min, max);
    }
    return arrey;
}

// Принт шапки задач
void PrintHeader(int[] arr, int n)
{
    Console.WriteLine();
    Console.WriteLine("Задачка №" + n);
    Console.WriteLine($"[{String.Join(", ", arr)}]");
}

/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
void CountEven(int[] arr)
{
    PrintHeader(arr, 1);
    int count = 0;
    for (int i=0; i < arr.Length; i++)
    {
        if (arr[i]% 2 == 0) count++;
    }
    Console.WriteLine("Количество чётных элементов = " + count);
}
CountEven(RandomArray(4,100,1000));

/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
void SumOdd(int[] arr)
{
    PrintHeader(arr, 2);
    int sum = 0;
    for (int i=1; i < arr.Length; i+=2)
    {
        sum += arr[i];
    }
    Console.WriteLine("Cумма элементов, стоящих на нечётных позициях = " + sum);
}
SumOdd(RandomArray(4, -99, 100));

/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
void DifferenceMaxMin(int[] arr)
{
    PrintHeader(arr, 3);
    int min = arr[0];
    int max = arr[0];
    for (int i=0; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        } else {
            if (min > arr[i]) min = arr[i];
        }
    }
    Console.WriteLine("Разница между максимальным и минимальным элементов массива = " + (max - min));
}
DifferenceMaxMin(RandomArray(5, 0, 100));
Console.WriteLine();