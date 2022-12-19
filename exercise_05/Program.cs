Console.Clear();
int[] array = {0, 0, 0, 0, 0};
int index = 0;

int GoMaxArray() {
    int max = 0;
    Console.WriteLine("Заполните массив из пяти чисел, и программа найдет максимальное из них");
    while (index < array.Length) {
        Console.WriteLine("Введите число " + index);
        array[index] = Convert.ToInt32(Console.ReadLine());
        if (max < array[index]) {
            max = array[index];
        }
        index++;
    }
    Console.WriteLine(string.Join(" ", array));
    return max;
}
Console.WriteLine("Максисмальное число в массиве = " + GoMaxArray());