// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
Console.Clear();

int[] ArrOne(int leng)
{
    int[] arr = new int[leng];
    for (int i=0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-99, 100);
    }
    return arr;
}

void ReversArr(int[] arr)
{
    Console.WriteLine($"[{String.Join(",",arr)}] ");
    for (int i=0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
    Console.WriteLine($"[{String.Join(",",arr)}]");
}
ReversArr(ArrOne(4));