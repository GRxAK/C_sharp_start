// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
Console.Clear();

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] arrayOne = CreateRandomArray(12, -9, 9);
ShowArray(arrayOne);

void Sum(int[] arr)
{
    int posetive = 0;
    int negative = 0;
    for(int i=0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {
            posetive += arr[i];
        } else {
            negative += arr[i];
        }
    }
    Console.WriteLine($"Сумма положительныйх чисел = {posetive}");
    Console.WriteLine($"Сумма от чисел = {negative}");
}

Sum(arrayOne);