// Console.Clear();
/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
void CountNumbs(int numb)
{
    int result = 0;
    if (numb == 0)
    {
        result = 1;
    }
    while(numb > 0)
    { 
        numb = numb / 10;
        result++;
    }
    Console.WriteLine(result);
}

Console.WriteLine("Введите число");
CountNumbs(Math.Abs(Convert.ToInt32(Console.ReadLine())));