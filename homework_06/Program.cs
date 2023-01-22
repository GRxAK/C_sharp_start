Console.Clear();
/* Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int[] WreatArray()
{
    Console.WriteLine("Введите длинну массива");
    int leng = 0;
    leng = int.Parse(Console.ReadLine());
    int[] arr = new int[leng];
    for (int i=0; i < leng; i++)
    {
        Console.WriteLine($"Введите чило для [{i}] элемента массива");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void CountPositiveNumbers(int[] arr)
{
    int count = 0;
    Console.Write($"[");
    for (int i=0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
        if (i == arr.Length - 1) Console.Write($"{arr[i]}");
        else Console.Write($"{arr[i]}, ");
    }
    Console.Write($"]");
    Console.WriteLine($" Количество положительных чисел в массиве {count}");
}

/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

void SearchDotsIntersection ()
{
    Console.WriteLine($"Введите коофециент 'b1'");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Введите коофециент 'k1'");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Введите коофециент 'b2'");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Введите коофециент 'k2'");
    double k2 = Convert.ToDouble(Console.ReadLine());

    if ((k1 - k2) != 0) 
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Координаты пересечения [{x}, {y}]");
    } 
    else Console.WriteLine("Не пересекаются, прямые параллельны");
} 

Console.WriteLine("Введите цифру '1' для запуска первой задачи или цифру '2' для запуска второй задачи");
int lesson = Convert.ToInt32(Console.ReadLine());
if (lesson == 1) CountPositiveNumbers(WreatArray());
else if (lesson == 2) SearchDotsIntersection();
else Console.WriteLine("Нет такой задачи");