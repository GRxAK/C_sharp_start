Console.Clear();
/* адайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

void ShouwNumbs(int start,int end)
{
    Console.Write($"{start}  ");
    if (start == end) return;
    ShouwNumbs(start + 1, end);
}

void LessonOne ()
{
    Console.WriteLine("Введите число:");
    int numb = Convert.ToInt32(Console.ReadLine());
    ShouwNumbs(0, numb);
    Console.WriteLine();
}

// LessonOne();

/* Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/



void LessonTwo ()
{
    Console.WriteLine("");
    int numb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
}

// LessonTwo();

/* Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int FunctionThree(int numb)
{
    int sum = 0;
    if (numb == 0) 
    {
        return 0;
    }
    sum = numb % 10 + FunctionThree(numb / 10);
    return sum;
}

void LessonThree ()
{
    Console.WriteLine("Read numb");
    int numb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(FunctionThree(numb));
    Console.WriteLine();
}

// LessonThree();

/* Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int Four(int a, int b)
{
    int c = 1;
    if (b == 0) return c;
    c = a * Four(a, b - 1);
    return c;
}

void LessonFour ()
{
    // Console.WriteLine("");
    // int numb = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine(Four(2,3));
}

// LessonFour();

