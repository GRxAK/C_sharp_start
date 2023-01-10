Console.Clear();
int[] array = {9, 665, 15, 1, 0, 9, 0, 47, 69, 25, 111, 561};

void PrintArray(int[] arr)
{
    for (int i=0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] arr)
{
    for (int i=0; i < arr.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] > arr[maxPosition])
            {
                maxPosition = j;
            }
            int temporey = arr[i];
            arr[i] = arr[maxPosition];
            arr[maxPosition] = temporey;
        }
    }
}

PrintArray(array);
SelectionSort(array);
PrintArray(array);