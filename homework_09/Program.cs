Console.Clear();
/* Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void ShowIntegers(int numb)
{
    if (numb == 0) return;
    Console.Write($"{numb}  ");
    ShowIntegers(numb - 1);
    return;
}

/* Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumNumber(int min, int max)
{
    int sum = 0;
    if (min == max) return max;
    sum = min + SumNumber(min + 1, max);
    return sum;
}

/* Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int Ackermann(int n, int m)
{
    if (n == 0) return m + 1;
    if ((n != 0) && (m == 0)) return Ackermann(n - 1, 1);
    else return Ackermann(n - 1, Ackermann(n, m - 1));
}


// запускаем задачки на выбор
void GoHomework()
{
    Console.WriteLine("Введите норме задачки 1, 2, 3");
    string lesson = Console.ReadLine();
    Console.WriteLine();
    switch (lesson)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Программа выведет все натуральные числа в промежутке от 8 до 1.");
            Console.WriteLine();
            ShowIntegers(8);
        break;
        case "2":
            Console.Clear();
            Console.WriteLine("Программа найдёт сумму натуральных элементов в промежутке от 4 до 8.");
            Console.WriteLine();
            Console.WriteLine(SumNumber(4,8));
            Console.WriteLine();
        break;
        case "3":
            Console.Clear();
            Console.WriteLine("Программа вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа 3 и 2.");
            Console.WriteLine();
            Console.WriteLine(Ackermann(3,2));
            Console.WriteLine(); 
        break;
        default:
            Console.Clear();
            Console.WriteLine("Попробуйте заного, такой задачи нет!");
            GoHomework();
        break;
    }
}

GoHomework();