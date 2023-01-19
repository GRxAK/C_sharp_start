Console.Clear();

// int[] RandomArray(int leng, int min, int max)
// {
//     int[] arrey = new int[leng];
//     for (int i=0; i < arrey.Length; i++)
//     {
//         arrey[i] = new Random().Next(min, max);
//     }
//     return arrey;
// }

/* Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
*/

// void ReversArray(int[] arr)
// {
//     Console.WriteLine($"[{String.Join(", ", arr)}]");
//     int temp = 0;
//     int lastIndex = arr.Length - 1;
//     for (int i=0; i < arr.Length/2; i++)
//     {
//         temp = arr[i];
//         arr[i] = arr[lastIndex];
//         arr[lastIndex] = temp;
//         lastIndex--;
//     }
//     Console.WriteLine($"[{String.Join(", ", arr)}]");
// }

// ReversArray(RandomArray(7,0,100));

/* Напишите программу, которая принимает на вход три числа и проверяет,
может ли существовать треугольник со сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/
// int[] RandomThreeArr()
// {
//     int[] arr = new int[3];
//     for(int i=0; i < 3; i++)
//     {
//         arr[i] = new Random().Next(10);
//     }
//     Console.WriteLine($"[{String.Join(", ", arr)}]");
//     return arr;
// }
// void CheckTriangle( int[] arr)
// {
//     if ((arr[0] < (arr[1] + arr[2])) && (arr[1] < (arr[2] + arr[0])) && (arr[2] < (arr[0] + arr[1])))
//     {
//         Console.WriteLine("Да моежт быть триугольник");
//     } else {
//         Console.WriteLine("Нет не может быть триугольик");
//     }
// }

// CheckTriangle(RandomThreeArr());

/* Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

// void DecimalBinary(int numb)
// {
//     string residue = string.Empty;
//     while (numb > 0)
//     {
//         residue = Convert.ToString(numb % 2) + residue;
//         numb /= 2;
//         Console.WriteLine(numb);
//     }
//     Console.WriteLine(residue);
// }

// DecimalBinary(14);

/* Не используя рекурсию, выведите первые N чисел Фибоначчи.
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

void Fibonacci(int numb)
{
    if (numb > 1)
    {
        Console.Write($"Если = {numb} -> 0 ");
        int numbA = 0;
        int numbB = 1;
        while(numb != 0)
        {
            Console.Write($"{numbB} ");
            numbB++;
            numb--; 
        }
    } else {
        Console.WriteLine($"Если = {numb} -> 0 1");
    }
}

Fibonacci(5);

/* Напишите программу, которая будет создавать копию заданного
массива с помощью поэлементного копирования.
*/